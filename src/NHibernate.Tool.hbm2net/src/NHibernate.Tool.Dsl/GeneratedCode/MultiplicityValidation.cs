﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
using DslValidation = global::Microsoft.VisualStudio.Modeling.Validation;
namespace NHibernate.NHDesigner
{
	[DslValidation::ValidationState(DslValidation::ValidationState.Enabled)]
	public abstract partial class Identifier
	{
		/// <summary>
		/// Checks that the relationships that have a multiplicity of One or OneMany do actually have a link.
		/// </summary>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "Generated code.")]
		[DslValidation::ValidationMethod(DslValidation::ValidationCategories.Open | DslValidation::ValidationCategories.Save | DslValidation::ValidationCategories.Menu)]
		private void ValidateIdentifierMultiplicity (DslValidation::ValidationContext context)
		{
			if (this.Entity == null)
			{
				context.LogViolation(DslValidation::ViolationType.Error,
					string.Format(global::System.Globalization.CultureInfo.CurrentCulture, 
						NHibernate.NHDesigner.NHDesignerDomainModel.SingletonResourceManager.GetString("MinimumMultiplicityMissingLink"), 
						"Identifier", "", "Entity"),
						"DSL0001", this);
			}
		} // ValidateIdentifierMultiplicity
	} // class Identifier
} // NHibernate.NHDesigner

	
 