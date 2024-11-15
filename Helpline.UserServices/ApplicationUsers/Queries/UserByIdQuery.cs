﻿using Helpline.Contracts.v1.Responses;
using Helpline.Domain.Messaging;

namespace Helpline.UserServices.ApplicationUsers.Queries
{
    public sealed record UserByIdQuery(Guid UserId) : IQuery<UserResponse>;
}