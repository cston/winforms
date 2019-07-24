﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Resources;
using Xunit;

namespace System.Windows.Forms.Tests.Serialization
{
    public class SerializableAttributeTests
    {
        [Fact]
        public void EnsureSerializableAttribute()
        {
            BinarySerialization.EnsureSerializableAttribute(
                typeof(Cursor).Assembly,
                new List<string>
                {
                    // Following classes are participating in resx serialization scenarios.
                    { typeof(AxHost.State).FullName},
                    { typeof(Cursor).FullName},
                    { typeof(ImageListStreamer).FullName},
                    { typeof(LinkArea).FullName},
                    { typeof(ListViewGroup).FullName},
                    { typeof(ListViewItem).FullName},
                    { typeof(ListViewItem.ListViewSubItem).FullName},
                    { "System.Windows.Forms.ListViewItem+ListViewSubItem+SubItemStyle"},  // Private type.
                    { typeof(OwnerDrawPropertyBag).FullName},
                    { typeof(Padding).FullName},
                    { typeof(ResXDataNode).FullName},
                    { typeof(ResXFileRef).FullName},
                    { typeof(TreeNode).FullName},
                    { typeof(TableLayoutSettings).FullName},
                    // This class is defined by CoreFx, we own only a partial implementation of it.
                    { "System.LocalAppContext+<>c"}
                });
        }
    }
}
