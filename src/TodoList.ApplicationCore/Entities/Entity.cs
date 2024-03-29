﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TodoList.ApplicationCore.Entities
{
    public class Entity
    {
        public Guid Id { get; protected set; }

        public override string ToString()
        {
            return GetType().Name + "[Id = " + Id + "]";
        }
    }

}
