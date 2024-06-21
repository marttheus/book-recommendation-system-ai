using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace BookRecommendationSystemAI.Infra.Helpers;

public class UlidValueGenerator : ValueGenerator<Ulid>
{
    public override Ulid Next(EntityEntry entry)
    {
        return Ulid.NewUlid();
    }

    public override bool GeneratesTemporaryValues => false;
}