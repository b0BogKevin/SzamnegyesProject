using System;
using System.Collections.Generic;

namespace szamnegyes3.Models;

public partial class Szamnegye
{
    public Guid? Id { get; set; }

    public int[] Szamok { get; set; }
}
