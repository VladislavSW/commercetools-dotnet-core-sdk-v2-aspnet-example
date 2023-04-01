using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;
using commercetools.Base.CustomAttributes;
using commercetools.Sdk.Serialization;
using Newtonsoft.Json;

namespace commercetools.Sdk.V2Compat.JsonConverters
{
    public class TypeDiscriminatorConverterFactory : JsonConverterBase
    {
        private readonly ConcurrentDictionary<Type, JsonConverter> _converters;

        public TypeDiscriminatorConverterFactory()
        {
            _converters = new ConcurrentDictionary<Type, JsonConverter>();
        }

        public override List<SerializerType> SerializerTypes =>
            new List<SerializerType>() { SerializerType.Deserialization };

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            if (!_converters.TryGetValue(objectType, out var converter))
            {
                var converterType = typeof(TypeDiscriminatorConverter<>).MakeGenericType(objectType);
                converter = Activator.CreateInstance(converterType) as JsonConverter;
                _converters.TryAdd(objectType, converter);
            }

            return converter?.ReadJson(reader, objectType, existingValue, serializer) ??
                   throw new JsonException($"Failed to instantiate converter for object type '{objectType.FullName}'");
        }

        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert.IsClass && typeToConvert.IsAbstract &&
                   typeToConvert.IsDefined(typeof(TypeDiscriminatorAttribute));
        }
    }
}