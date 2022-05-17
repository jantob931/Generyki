using AplikacjaGIt2.Entities;
using System.Text.Json;

namespace Generyki1.Entities.Extensions;

public static class EntityExtentions
{
    public static T? Copy<T>(this T itemCopy) where T : IEntity
    {
        //serializacja
        var json = JsonSerializer.Serialize<T>(itemCopy);
        return JsonSerializer.Deserialize<T>(json);
    }
    
}

