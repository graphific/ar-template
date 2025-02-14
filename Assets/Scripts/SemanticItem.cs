// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// adapted from https://github.com/google-ar/demo-megagolf

using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SemanticItem : MonoBehaviour
{
    [SerializeField]
    private Image image;
    
    [SerializeField]
    private TextMeshProUGUI percentText;

    [SerializeField]
    private Image color;
    
    public Image Image => image;
    public TextMeshProUGUI Text => percentText;

    public Image Color => color;
}