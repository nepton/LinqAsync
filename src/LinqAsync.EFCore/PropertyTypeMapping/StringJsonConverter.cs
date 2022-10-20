using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Doulex.EntityFrameworkCore.Extensions.PropertyTypeMapping;

/// <summary>
/// 负责把实体值对象转换为 Json 字符串格式存储于数据库
/// </summary>
public class StringJsonConverter<TModel> : ValueConverter<TModel, string>
{
    public StringJsonConverter(ConverterMappingHints? mappingHints = null)
        : base(v => JsonSerializer.Serialize(v, new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            }),
            v => JsonSerializer.Deserialize<TModel>(v, new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            })!, mappingHints)
    {
    }
}
