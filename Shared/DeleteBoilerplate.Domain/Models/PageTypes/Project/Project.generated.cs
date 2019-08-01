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

[assembly: RegisterDocumentType(Project.CLASS_NAME, typeof(Project))]

namespace CMS.DocumentEngine.Types.DeleteBoilerplate
{
    /// <summary>
    /// Represents a content item of type Project.
    /// </summary>
    public partial class Project : TreeNode
    {
        #region "Constants and variables"

        /// <summary>
        /// The name of the data class.
        /// </summary>
        public const string CLASS_NAME = "DeleteBoilerplate.Project";


        /// <summary>
        /// The instance of the class that provides extended API for working with Project fields.
        /// </summary>
        private readonly ProjectFields mFields;

        #endregion


        #region "Properties"

        /// <summary>
        /// ProjectID.
        /// </summary>
        [DatabaseIDField]
        public int ProjectID
        {
            get
            {
                return ValidationHelper.GetInteger(GetValue("ProjectID"), 0);
            }
            set
            {
                SetValue("ProjectID", value);
            }
        }


        /// <summary>
        /// Image.
        /// </summary>
        [DatabaseField]
        public string Image
        {
            get
            {
                return ValidationHelper.GetString(GetValue("Image"), @"");
            }
            set
            {
                SetValue("Image", value);
            }
        }


        /// <summary>
        /// Year.
        /// </summary>
        [DatabaseField]
        public int Year
        {
            get
            {
                return ValidationHelper.GetInteger(GetValue("Year"), 0);
            }
            set
            {
                SetValue("Year", value);
            }
        }


        /// <summary>
        /// Title.
        /// </summary>
        [DatabaseField]
        public string Title
        {
            get
            {
                return ValidationHelper.GetString(GetValue("Title"), @"");
            }
            set
            {
                SetValue("Title", value);
            }
        }


        /// <summary>
        /// Description.
        /// </summary>
        [DatabaseField]
        public string Description
        {
            get
            {
                return ValidationHelper.GetString(GetValue("Description"), @"");
            }
            set
            {
                SetValue("Description", value);
            }
        }


        /// <summary>
        /// Seo Url.
        /// </summary>
        [DatabaseField]
        public string SeoUrl
        {
            get
            {
                return ValidationHelper.GetString(GetValue("SeoUrl"), @"");
            }
            set
            {
                SetValue("SeoUrl", value);
            }
        }


        /// <summary>
        /// Taxonomy.
        /// </summary>
        [DatabaseField]
        public string Taxonomy
        {
            get
            {
                return ValidationHelper.GetString(GetValue("Taxonomy"), @"");
            }
            set
            {
                SetValue("Taxonomy", value);
            }
        }


        /// <summary>
        /// Area.
        /// </summary>
        [DatabaseField]
        public string Area
        {
            get
            {
                return ValidationHelper.GetString(GetValue("Area"), @"");
            }
            set
            {
                SetValue("Area", value);
            }
        }


        /// <summary>
        /// Additional Area.
        /// </summary>
        [DatabaseField]
        public string AdditionalArea
        {
            get
            {
                return ValidationHelper.GetString(GetValue("AdditionalArea"), @"");
            }
            set
            {
                SetValue("AdditionalArea", value);
            }
        }


        /// <summary>
        /// Gets an object that provides extended API for working with Project fields.
        /// </summary>
        [RegisterProperty]
        public ProjectFields Fields
        {
            get
            {
                return mFields;
            }
        }


        /// <summary>
        /// Provides extended API for working with Project fields.
        /// </summary>
        [RegisterAllProperties]
        public partial class ProjectFields : AbstractHierarchicalObject<ProjectFields>
        {
            /// <summary>
            /// The content item of type Project that is a target of the extended API.
            /// </summary>
            private readonly Project mInstance;


            /// <summary>
            /// Initializes a new instance of the <see cref="ProjectFields" /> class with the specified content item of type Project.
            /// </summary>
            /// <param name="instance">The content item of type Project that is a target of the extended API.</param>
            public ProjectFields(Project instance)
            {
                mInstance = instance;
            }


            /// <summary>
            /// ProjectID.
            /// </summary>
            public int ID
            {
                get
                {
                    return mInstance.ProjectID;
                }
                set
                {
                    mInstance.ProjectID = value;
                }
            }


            /// <summary>
            /// Image.
            /// </summary>
            public string Image
            {
                get
                {
                    return mInstance.Image;
                }
                set
                {
                    mInstance.Image = value;
                }
            }


            /// <summary>
            /// Year.
            /// </summary>
            public int Year
            {
                get
                {
                    return mInstance.Year;
                }
                set
                {
                    mInstance.Year = value;
                }
            }


            /// <summary>
            /// Title.
            /// </summary>
            public string Title
            {
                get
                {
                    return mInstance.Title;
                }
                set
                {
                    mInstance.Title = value;
                }
            }


            /// <summary>
            /// Description.
            /// </summary>
            public string Description
            {
                get
                {
                    return mInstance.Description;
                }
                set
                {
                    mInstance.Description = value;
                }
            }


            /// <summary>
            /// Seo Url.
            /// </summary>
            public string SeoUrl
            {
                get
                {
                    return mInstance.SeoUrl;
                }
                set
                {
                    mInstance.SeoUrl = value;
                }
            }


            /// <summary>
            /// Taxonomy.
            /// </summary>
            public string Taxonomy
            {
                get
                {
                    return mInstance.Taxonomy;
                }
                set
                {
                    mInstance.Taxonomy = value;
                }
            }


            /// <summary>
            /// Area.
            /// </summary>
            public string Area
            {
                get
                {
                    return mInstance.Area;
                }
                set
                {
                    mInstance.Area = value;
                }
            }


            /// <summary>
            /// Additional Area.
            /// </summary>
            public string AdditionalArea
            {
                get
                {
                    return mInstance.AdditionalArea;
                }
                set
                {
                    mInstance.AdditionalArea = value;
                }
            }
        }

        #endregion


        #region "Constructors"

        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        public Project() : base(CLASS_NAME)
        {
            mFields = new ProjectFields(this);
        }

        #endregion
    }
}