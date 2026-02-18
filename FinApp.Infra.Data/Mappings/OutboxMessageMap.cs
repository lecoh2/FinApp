using FinApp.Domain.Messages.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Infra.Data.Mappings
{
    public class OutboxMessageMap : IEntityTypeConfiguration<OutboxMessage>
    {
        public void Configure(EntityTypeBuilder<OutboxMessage> builder)
        {
            builder.ToTable("OUTBOX_MESSAGE");

            builder.HasKey(o => o.Id);

            builder.Property(o => o.Id).HasColumnName("ID");
            builder.Property(o => o.Type)
.HasColumnName("TYPE").HasMaxLength(50);
            builder.Property(o => o.Payload)
.HasColumnName("PAYLOAD").HasMaxLength(1000);
            builder.Property(o => o.CreatedAt).HasColumnName("CREATED_AT");
            builder.Property(o => o.Processed).HasColumnName("PROCESSED");
            builder.Property(o => o.ProcessedAt)
.HasColumnName("PROCESSED_AT");
        }
    }
}
