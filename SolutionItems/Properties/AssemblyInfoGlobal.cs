using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;


[assembly: AssemblyCopyright("Copyright � 2014")]
[assembly: AssemblyVersion("0.1.2.7")]
#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
[assembly: AssemblyInformationalVersion("0.1.2.7-beta-tx")]    // trigger pre release package
#else
    [assembly: AssemblyConfiguration("Release")]
#endif
[assembly: InternalsVisibleTo("Neo4jClient.Extension.Test")]
[assembly: ComVisible(false)]