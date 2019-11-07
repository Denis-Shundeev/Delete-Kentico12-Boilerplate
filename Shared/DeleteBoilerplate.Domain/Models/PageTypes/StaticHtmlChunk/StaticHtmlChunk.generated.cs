//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at http://docs.kentico.com.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine.Types.DeleteBoilerplate;
using CMS.DocumentEngine;

[assembly: RegisterDocumentType(StaticHtmlChunk.CLASS_NAME, typeof(StaticHtmlChunk))]

namespace CMS.DocumentEngine.Types.DeleteBoilerplate
{
	/// <summary>
	/// Represents a content item of type StaticHtmlChunk.
	/// </summary>
	public partial class StaticHtmlChunk : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "DeleteBoilerplate.StaticHtmlChunk";


		/// <summary>
		/// The instance of the class that provides extended API for working with StaticHtmlChunk fields.
		/// </summary>
		private readonly StaticHtmlChunkFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// StaticHtmlChunkID.
		/// </summary>
		[DatabaseIDField]
		public int StaticHtmlChunkID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("StaticHtmlChunkID"), 0);
			}
			set
			{
				SetValue("StaticHtmlChunkID", value);
			}
		}


		/// <summary>
		/// HTML.
		/// </summary>
		[DatabaseField]
		public string Html
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Html"), @"");
			}
			set
			{
				SetValue("Html", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with StaticHtmlChunk fields.
		/// </summary>
		[RegisterProperty]
		public StaticHtmlChunkFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with StaticHtmlChunk fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class StaticHtmlChunkFields : AbstractHierarchicalObject<StaticHtmlChunkFields>
		{
			/// <summary>
			/// The content item of type StaticHtmlChunk that is a target of the extended API.
			/// </summary>
			private readonly StaticHtmlChunk mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="StaticHtmlChunkFields" /> class with the specified content item of type StaticHtmlChunk.
			/// </summary>
			/// <param name="instance">The content item of type StaticHtmlChunk that is a target of the extended API.</param>
			public StaticHtmlChunkFields(StaticHtmlChunk instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// StaticHtmlChunkID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.StaticHtmlChunkID;
				}
				set
				{
					mInstance.StaticHtmlChunkID = value;
				}
			}


			/// <summary>
			/// HTML.
			/// </summary>
			public string Html
			{
				get
				{
					return mInstance.Html;
				}
				set
				{
					mInstance.Html = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="StaticHtmlChunk" /> class.
		/// </summary>
		public StaticHtmlChunk() : base(CLASS_NAME)
		{
			mFields = new StaticHtmlChunkFields(this);
		}

		#endregion
	}
}