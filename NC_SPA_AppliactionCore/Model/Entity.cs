using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using eShop_ApplicationCore.Model.Interfaces;

namespace eShop_ApplicationCore.Model
{
    public class Entity : IEntity
    {
        public int Id { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; } = DateTime.Now;

        public DateTime? ModifiedDate { get; set; }

        
        private static bool SetterExists(PropertyInfo propertyInfo)
        {
            return propertyInfo.SetMethod != null;
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


        private bool IsValueChanged<T>(T source, PropertyInfo propertyInfo) where T : IEntity
        {
            var sourceValue = propertyInfo.GetValue(source);
            var targetValue = propertyInfo.GetValue(this);

            if (targetValue == null)
            {
                return sourceValue != null;
            }

            return !targetValue.Equals(sourceValue);
        }


        public virtual IEntity UpdateFromEntity(IEntity source)
        {
            if (source == null)
            {
                return this;
            }

            var entityProperties = GetEntityProperties(source.GetType());
            foreach (PropertyInfo propertyInfo in entityProperties)
            {
                if (SetterExists(propertyInfo) &&
                    IsValueChanged(source, propertyInfo))
                {
                    propertyInfo.SetValue(this, propertyInfo.GetValue(source));
                }

            }
            return this;
        }

    }
}
