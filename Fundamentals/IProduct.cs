using System;

namespace cs_playground.Fundamentals;

public interface IProduct
{
    void ApplyDiscount(decimal percentage);
    string GetDescription();
}
