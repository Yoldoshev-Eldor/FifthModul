﻿using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Dal.Entites;

public class Card
{
    [Key]
    public long CardId { get; set; }
    public long CustomerId { get; set; }
    public string Number { get; set; }
    public string HolderName { get; set; }
    public int ExpirationMonth { get; set; }
    public int ExpirationYear { get; set; }
    public int? Cvv { get; set; }
    public bool SelectedForPayment { get; set; }
    public Customer Customer { get; set; }
}

