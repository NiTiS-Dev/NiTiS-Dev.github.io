// Disable by <NBT_SignAssembly>false</NBT_SignAssembly>
namespace NiTiS.Build.Tools {
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
	[System.ComponentModel.Browsable(false)]
	[System.AttributeUsage(System.AttributeTargets.Assembly, Inherited=true)]
	internal class BuildWithNiTiSBuildToolsAttribute : System.Attribute {}
}
[assembly:BuildWithNiTiSBuildToolsAttribute]
