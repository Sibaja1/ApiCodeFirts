﻿using System;
using System.Collections.Generic;

namespace APICliente.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }
}
