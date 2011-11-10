﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Petshop.Data.Mapping
{
    public partial class OrderStatusMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Petshop.Data.Entities.OrderStatus>
    {
        public OrderStatusMap()
        {
            // table
            ToTable("OrderStatus", "dbo");

            // keys
            HasKey(t => new { t.OrderId, t.LineNum });

            // Properties
            Property(t => t.OrderId)
                .HasColumnName("OrderId")
                .IsRequired();
            Property(t => t.LineNum)
                .HasColumnName("LineNum")
                .IsRequired();
            Property(t => t.Timestamp)
                .HasColumnName("Timestamp")
                .IsRequired();
            Property(t => t.Status)
                .HasColumnName("Status")
                .HasMaxLength(2)
                .IsRequired();

            // Relationships
            HasRequired(t => t.Order)
                .WithMany(t => t.OrderStatusList)
                .HasForeignKey(d => d.OrderId);

            InitializeMapping();
        }
    }
}

