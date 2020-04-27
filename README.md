# Uni Storage

ストレージの空き容量を返すクラス

## 使用例

```cs
using UniStorage;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void OnGUI()
    {
        GUILayout.Label( ToReadableSize( Storage.GetFreeSpace() ) );
    }
    
    private static string ToReadableSize( double size, int scale = 0, int standard = 1024 )
    {
        var unit = new[] { "B", "KB", "MB", "GB" };
        if ( scale == unit.Length - 1 || size <= standard )
        {
            return $"{size:.##} {unit[ scale ]}";
        }

        return ToReadableSize( size / standard, scale + 1, standard );
    }
}
```