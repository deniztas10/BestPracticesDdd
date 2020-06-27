using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace BestPractiesDdd.Domain.Domains.Labes
{
    public class Label
    {
        [NotNull]
        public Guid Id { get; private set; }

        [NotNull]
        public string Name { get; private set; }

        private Label(){ }

        public Label(
            Guid id,
            string name
            )
        {
            Id = id;
            Name = name;           
        }

        public void SetName(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new Exception("Name is not be null !");
            }

            Name = name;
        }
    }
}
