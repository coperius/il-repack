﻿//
// Copyright (c) 2015 Timotei Dolean
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
//
using Mono.Cecil;
using System.Collections.Generic;

namespace ILRepacking
{
    public interface IRepackContext
    {
        List<AssemblyDefinition> MergedAssemblies { get; }
        ModuleDefinition TargetAssemblyMainModule { get; }
        PlatformFixer PlatformFixer { get; }
        ReflectionHelper ReflectionHelper { get; }
        MappingHandler MappingHandler { get; }
        IKVMLineIndexer LineIndexer { get; }
        AssemblyDefinition TargetAssemblyDefinition { get; }
        List<AssemblyDefinition> OtherAssemblies { get; }
        AssemblyDefinition PrimaryAssemblyDefinition { get; }
        ModuleDefinition PrimaryAssemblyMainModule { get; }

        TypeDefinition GetMergedTypeFromTypeRef(TypeReference reference);

        string FixTypeName(string assemblyName, string typeName);
        string FixAssemblyName(string assemblyName);
        string FixStr(string content);

        TypeReference GetExportedTypeFromTypeRef(TypeReference type);
    }
}
