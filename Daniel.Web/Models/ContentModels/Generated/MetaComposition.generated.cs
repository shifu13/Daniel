//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v10.2.0+ae516b2
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Ecreo.Essentials.UmbracoTemplate.Models.ContentModels
{
	// Mixin Content Type with alias "metaComposition"
	/// <summary>#Meta</summary>
	public partial interface IMetaComposition : IPublishedElement
	{
		/// <summary>#Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.0+ae516b2")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string MetaDescription { get; }

		/// <summary>#Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.0+ae516b2")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string MetaTitle { get; }

		/// <summary>#Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.0+ae516b2")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::Umbraco.Cms.Core.Models.MediaWithCrops OpenGraphImage { get; }

		/// <summary>#Robots access</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.0+ae516b2")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string RobotsTxt { get; }
	}

	/// <summary>#Meta</summary>
	[PublishedModel("metaComposition")]
	public partial class MetaComposition : PublishedElementModel, IMetaComposition
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.0+ae516b2")]
		public new const string ModelTypeAlias = "metaComposition";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.0+ae516b2")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.0+ae516b2")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.0+ae516b2")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<MetaComposition, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public MetaComposition(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// #Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.0+ae516b2")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("metaDescription")]
		public virtual string MetaDescription => GetMetaDescription(this, _publishedValueFallback);

		/// <summary>Static getter for #Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.0+ae516b2")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetMetaDescription(IMetaComposition that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "metaDescription");

		///<summary>
		/// #Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.0+ae516b2")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("metaTitle")]
		public virtual string MetaTitle => GetMetaTitle(this, _publishedValueFallback);

		/// <summary>Static getter for #Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.0+ae516b2")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetMetaTitle(IMetaComposition that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "metaTitle");

		///<summary>
		/// #Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.0+ae516b2")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("openGraphImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OpenGraphImage => GetOpenGraphImage(this, _publishedValueFallback);

		/// <summary>Static getter for #Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.0+ae516b2")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::Umbraco.Cms.Core.Models.MediaWithCrops GetOpenGraphImage(IMetaComposition that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(publishedValueFallback, "openGraphImage");

		///<summary>
		/// #Robots access
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.0+ae516b2")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("robotsTxt")]
		public virtual string RobotsTxt => GetRobotsTxt(this, _publishedValueFallback);

		/// <summary>Static getter for #Robots access</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.0+ae516b2")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetRobotsTxt(IMetaComposition that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "robotsTxt");
	}
}
