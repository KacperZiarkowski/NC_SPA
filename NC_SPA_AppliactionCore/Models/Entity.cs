using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using NC_SPA_AppliactionCore.Models.Abstract;

namespace NC_SPA_AppliactionCore.Models
{
    public class Entity : IEntity
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual IEntity UpdateFromEntity(IEntity source)
        {
            if (source == null)
            {
                return this;
            }

            var entityProperties = GetEntityProperties(source.GetType());
            foreach (PropertyInfo propertyInfo in entityProperties)
            {
                
            }

        }

        private static PropertyInfo[] GetEntityProperties(Type type)
        {
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            return
                properties
                    .Where(p => !(
                        p.PropertyType.IsGenericType &&
                        p.PropertyType.GetGenericTypeDefinition() == typeof(ICollection<>)))
                    .ToArray();
        }
    }

}
