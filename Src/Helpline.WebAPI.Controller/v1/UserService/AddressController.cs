﻿using Helpline.Common.Constants;
using Helpline.Contracts.v1.Responses;
using Helpline.Domain.Shared;
using Helpline.UserServices.Addresses.Commands;
using Helpline.UserServices.Addresses.Queries;
using Helpline.WebAPI.Controller.v1.SubscriptionService.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Helpline.WebAPI.Controller.v1.UserService
{
    public partial class UserServicesController
    {

        [HttpGet]
        [Route(HelplineRoutes.AddressByIdRoute)]
        public async Task<IActionResult> GetUserAddress(Guid userId, CancellationToken cancellationToken)
        {
            var query = new AddressByUserIdQuery(userId);

            Result<AddressResponse> response = await Sender.Send(query, cancellationToken);

            return response.IsSuccess ? Ok(response.Value) : BadRequest(response.Error);
        }

        [HttpPut]
        [Route(HelplineRoutes.AddressByIdRoute)]
        public async Task<IActionResult> UpdateAddress(Guid userId, [FromBody] UpdateAddressRequest request, CancellationToken cancellationToken)
        {
            var command = new AddressUpdateCommand(
                userId,
                request.Address1,
                request.Address2,
                request.City,
                request.State,
                request.ZipCode);

            Result result = await Sender.Send(command, cancellationToken);

            return result.IsSuccess ? Ok(userId) : BadRequest(result.Error);
        }
    }
}