using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC_Converter
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class InportExportMaterial
    {

        private InportExportMaterialExportInfo exportInfoField;

        private InportExportMaterialMaterialSaveLoad materialSaveLoadField;

        /// <remarks/>
        public InportExportMaterialExportInfo ExportInfo
        {
            get
            {
                return this.exportInfoField;
            }
            set
            {
                this.exportInfoField = value;
            }
        }

        /// <remarks/>
        public InportExportMaterialMaterialSaveLoad MaterialSaveLoad
        {
            get
            {
                return this.materialSaveLoadField;
            }
            set
            {
                this.materialSaveLoadField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportMaterialExportInfo
    {

        private string exportDateField;

        private string versionField;

        private string authorField;

        /// <remarks/>
        public string ExportDate
        {
            get
            {
                return this.exportDateField;
            }
            set
            {
                this.exportDateField = value;
            }
        }

        /// <remarks/>
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        public string Author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportMaterialMaterialSaveLoad
    {

        private InportExportMaterialMaterialSaveLoadExportInfo exportInfoField;

        private string materialNameField;

        private string textureNameField;

        private string shaderNameField;

        private string blendModeField;

        private string uvDescTypeField;

        /// <remarks/>
        public InportExportMaterialMaterialSaveLoadExportInfo ExportInfo
        {
            get
            {
                return this.exportInfoField;
            }
            set
            {
                this.exportInfoField = value;
            }
        }

        /// <remarks/>
        public string materialName
        {
            get
            {
                return this.materialNameField;
            }
            set
            {
                this.materialNameField = value;
            }
        }

        /// <remarks/>
        public string textureName
        {
            get
            {
                return this.textureNameField;
            }
            set
            {
                this.textureNameField = value;
            }
        }

        /// <remarks/>
        public string shaderName
        {
            get
            {
                return this.shaderNameField;
            }
            set
            {
                this.shaderNameField = value;
            }
        }

        /// <remarks/>
        public string blendMode
        {
            get
            {
                return this.blendModeField;
            }
            set
            {
                this.blendModeField = value;
            }
        }

        /// <remarks/>
        public string uvDescType
        {
            get
            {
                return this.uvDescTypeField;
            }
            set
            {
                this.uvDescTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportMaterialMaterialSaveLoadExportInfo
    {

        private string exportDateField;

        private string versionField;

        private string authorField;

        /// <remarks/>
        public string ExportDate
        {
            get
            {
                return this.exportDateField;
            }
            set
            {
                this.exportDateField = value;
            }
        }

        /// <remarks/>
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        public string Author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }
    }

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Material
    {


        private MaterialTexture textureField;

        private MaterialBlendMode blendModeField;

        private MaterialAddressMode addressModeField;

        private MaterialSplit splitField;

        private MaterialShader shaderField;

        private string nameField;

        public Material()
        {
            Texture = new MaterialTexture();
            BlendMode = new MaterialBlendMode();
            AddressMode = new MaterialAddressMode();
            Split = new MaterialSplit();
            Split.U = 1;
            Split.V = 1;
            Shader = new MaterialShader();
            Name = "";
        }

        /// <remarks/>
        public MaterialTexture Texture
        {
            get
            {
                return this.textureField;
            }
            set
            {
                this.textureField = value;
            }
        }

        /// <remarks/>
        public MaterialBlendMode BlendMode
        {
            get
            {
                return this.blendModeField;
            }
            set
            {
                this.blendModeField = value;
            }
        }

        /// <remarks/>
        public MaterialAddressMode AddressMode
        {
            get
            {
                return this.addressModeField;
            }
            set
            {
                this.addressModeField = value;
            }
        }

        /// <remarks/>
        public MaterialSplit Split
        {
            get
            {
                return this.splitField;
            }
            set
            {
                this.splitField = value;
            }
        }

        /// <remarks/>
        public MaterialShader Shader
        {
            get
            {
                return this.shaderField;
            }
            set
            {
                this.shaderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MaterialTexture
    {

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MaterialBlendMode
    {

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MaterialAddressMode
    {

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MaterialSplit
    {

        private byte uField;

        private byte vField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte U
        {
            get
            {
                return this.uField;
            }
            set
            {
                this.uField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte V
        {
            get
            {
                return this.vField;
            }
            set
            {
                this.vField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MaterialShader
    {

        private MaterialShaderParameter[] parameterField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public MaterialShaderParameter[] Parameter
        {
            get
            {
                return this.parameterField;
            }
            set
            {
                this.parameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MaterialShaderParameter
    {

        private byte idField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }



}
