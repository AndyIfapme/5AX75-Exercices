using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp_02.Domain;

namespace WebApp_02.Infractructure.Configurations;

public class ContactConfiguration : IEntityTypeConfiguration<Contact>
{
    //https://learn.microsoft.com/fr-fr/ef/core/modeling/entity-types?tabs=data-annotations
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
       builder.HasKey(x => x.Id);
      // builder.Property(x => x.Subject).IsRequired(true);
    }
}