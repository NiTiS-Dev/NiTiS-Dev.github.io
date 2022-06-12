// Disable by <NBT_SignAssembly>false</NBT_SignAssembly>
[assembly:NiTiS.Build.Tools.BuildWithNiTiSBuildTools]


namespace NiTiS.Build.Tools {
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
	[System.ComponentModel.Browsable(false)]
	[System.AttributeUsage(System.AttributeTargets.Assembly, Inherited=true)]
	internal sealed class BuildWithNiTiSBuildToolsAttribute : System.Attribute {}
}