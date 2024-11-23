﻿using Helpline.Contracts.v1.Responses;
using Helpline.Services.Abstractions.Messaging;

namespace Helpline.Services.Users.Employees.Queries
{
    public sealed record EmployeesAllQuery() : IQuery<IEnumerable<EmployeeResponse>>;
}