﻿using E_Commerce.Dal.Entites;

namespace E_Commerce.Repository.Services;

public class CardRepository : ICardRepository
{
    public Task AssignCardAsNotSelectedAsync(long cardId)
    {
        throw new NotImplementedException();
    }

    public Task AssignCardAsSelectedAsync(long cardId)
    {
        throw new NotImplementedException();
    }

    public Task DeleteCardAsync(long cardId)
    {
        throw new NotImplementedException();
    }

    public Task<long> InsertCardAsync(Card card)
    {
        throw new NotImplementedException();
    }

    public Task<List<Card>> SelectCardsByCustomerIdAsync(long customerId)
    {
        throw new NotImplementedException();
    }

    public Task<Card> SelectSelectedCardByCustomerIdAsync(long customerId)
    {
        throw new NotImplementedException();
    }
}
