using System.Text.Json;
using Generyki1.Data.Entities;

namespace Generyki1.Data.Entities.Extensions;

public static class EntityExtentions
{
    public static T? Copy<T>(this T itemCopy) where T : IEntity
    {
        //serializacja
        var json = JsonSerializer.Serialize<T>(itemCopy);
        return JsonSerializer.Deserialize<T>(json);
    }
    
}

