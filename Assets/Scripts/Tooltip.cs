using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class Tooltip : MonoBehaviour
{

    public TextMeshProUGUI header;
    public TextMeshProUGUI content;
    public LayoutElement layout;
    public int charWrapLimit;

    private void Update()
    {
        int headerLength= header.text.Length;
        int contentLength = content.text.Length;

        layout.enabled = Mathf.Max(header.preferredWidth, content.preferredWidth) >= layout.preferredWidth;
    }
}
