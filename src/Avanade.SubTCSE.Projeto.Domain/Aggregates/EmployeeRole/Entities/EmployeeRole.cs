﻿namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Entities
{
    public class EmployeeRole
    {
        public EmployeeRole(string id, string roleName)
        {
            Id = id;

            RoleName = roleName;
        }


        public string Id { get; set; }

        public string RoleName { get; set; }


    }
}
