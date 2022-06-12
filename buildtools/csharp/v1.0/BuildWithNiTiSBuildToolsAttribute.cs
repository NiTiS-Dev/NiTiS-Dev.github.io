// Disable by <NBT_SignAssembly>false</NBT_SignAssembly>
namespace NiTiS.Build.Tools {
	[System.AttributeUsage(System.AttributeTargets.Assembly, Inherited=true)]
	internal class BuildWithNiTiSBuildToolsAttribute : System.Attribute {}
}
[assembly:BuildWithNiTiSBuildToolsAttribute]