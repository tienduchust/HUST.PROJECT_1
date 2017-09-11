using System.Data.Entity;
using System.Collections.Generic;
using System;
using System.Reflection;
using System.Collections.ObjectModel;
using System.Linq;

namespace Hust.Models
{
    public partial class DataBaseContext : DbContext
    {
        private static IReadOnlyDictionary<Type, IReadOnlyCollection<PropertyInfo>> _ignoredProperties;

        static DataBaseContext()
        {
            Database.SetInitializer<DataBaseContext>(null);
        }
        public DataBaseContext()
            : base("Name=PPUPIContext")
        {
        }
        public static IReadOnlyDictionary<Type, IReadOnlyCollection<PropertyInfo>> IgnoredProperties
        {
            get
            {
                return _ignoredProperties;
            }
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new UserProfileMap());
           

            if (_ignoredProperties == null)
            {
                var model = modelBuilder.Build(this.Database.Connection);
                var mappedEntityTypes = new Dictionary<Type, IReadOnlyCollection<PropertyInfo>>();
                foreach (var entityType in model.ConceptualModel.EntityTypes)
                {
                    var type = Type.GetType(entityType.FullName);
                    var typeProperties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
                    var mappedProperties = entityType.DeclaredProperties.Select(t => t.Name)
                        .Union(entityType.NavigationProperties.Select(t => t.Name));
                    mappedEntityTypes.Add(type, new ReadOnlyCollection<PropertyInfo>(
                        typeProperties.Where(t => !mappedProperties.Contains(t.Name)).ToList()));
                }
                _ignoredProperties = new ReadOnlyDictionary<Type, IReadOnlyCollection<PropertyInfo>>(mappedEntityTypes);
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
