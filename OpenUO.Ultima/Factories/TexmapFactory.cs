﻿#region License Header

// /***************************************************************************
//  *   Copyright (c) 2011 OpenUO Software Team.
//  *   All Right Reserved.
//  *
//  *   TexmapFactory.cs
//  *
//  *   This program is free software; you can redistribute it and/or modify
//  *   it under the terms of the GNU General Public License as published by
//  *   the Free Software Foundation; either version 3 of the License, or
//  *   (at your option) any later version.
//  ***************************************************************************/

#endregion

#region Usings

using OpenUO.Core.Patterns;
using OpenUO.Ultima.Adapters;

#endregion

namespace OpenUO.Ultima
{
    public class TexmapFactory : AdapterFactoryBase
    {
        public TexmapFactory(InstallLocation install, IContainer container)
            : base(install, container)
        {
        }

        public T GetTexmap<T>(int index)
        {
            return GetAdapter<ITexmapStorageAdapter<T>>().GetTexmap(index);
        }
    }
}