using System;
using System.Collections.Generic;
using System.Text;

namespace SmartDepo.Services.DTO
{
    public abstract class BaseDTO
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; }
    }
}
