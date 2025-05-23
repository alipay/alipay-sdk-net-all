/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2025-02-19
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = AlipaySDKNet.OpenAPI.Client.OpenAPIDateConverter;

namespace AlipaySDKNet.OpenAPI.Model
{
    /// <summary>
    /// AlipayOpenMiniInnerversionBuildauditSubmitModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniInnerversionBuildauditSubmitModel")]
    public partial class AlipayOpenMiniInnerversionBuildauditSubmitModel : IEquatable<AlipayOpenMiniInnerversionBuildauditSubmitModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerversionBuildauditSubmitModel" /> class.
        /// </summary>
        /// <param name="appCategoryIds">小程序类目，可不传，不传取基础信息中的小程序类目.</param>
        /// <param name="appDesc">小程序描述，可不传，不传取基础信息中的小程序描述.</param>
        /// <param name="appEnglishName">小程序在从未上架过版本之前，英文名称是可以修改的，该字段用于在提交审核时候修改小程序英文名称。注意：小程序一旦有过上架版本之后就不可以修改英文名称。.</param>
        /// <param name="appLogo">小程序logo，可不传，不传取基础信息中的小程序logo，请调用专用的logo上传接口上传logo文件，并将返回的地址作为本字段传入.</param>
        /// <param name="appName">小程序在从未上架过版本之前，中文名称是可以修改的，该字段用于在提交审核时候修改小程序中文名称。注意：小程序一旦有过上架版本之后就不可以修改中文名称。.</param>
        /// <param name="appOrigin">来源类型，新接入方需要向支付宝申请专用来源，否则不予接入，申请方式请参见接入手册。.</param>
        /// <param name="appSlogan">小程序应用简介，一句话描述小程序功能，如果不填默认采用当前小程序应用简介，10~32个字符.</param>
        /// <param name="appVersion">小程序版本号.</param>
        /// <param name="buildExt">构建扩展参数.</param>
        /// <param name="bundleId">端信息.</param>
        /// <param name="isvAppId">三方应用ID.</param>
        /// <param name="licenseInfo">licenseInfo.</param>
        /// <param name="miniAppId">小程序ID，特殊场景专用，普通业务方无需关注该参数。.</param>
        /// <param name="miniCategoryIds">新小程序前台类目，格式为 第一个一级类目_第一个二级类目;第二个一级类目_第二个二级类目_第二个三级类目，详细类目可以通过 https://docs.open.alipay.com/api_49/alipay.open.mini.category.query接口查询mini_category_list，如果不填默认采用当前小程序应用类目。使用默认应用类目后不需要再次上传营业执照号、营业执照名、营业执照截图、营业执照有效期。使用后不再读取app_category_ids值，老前台类目将废弃.</param>
        /// <param name="pid">小程序开发者ID，可不传，不传取基础信息中的小程序开发者ID.</param>
        /// <param name="regionType">服务区域类型,可不传，不传取基础信息中的小程序服务区域类型.</param>
        /// <param name="screenShotList">版本截图，最少2张，最多5张，必传.</param>
        /// <param name="servicePhone">客服电话，可不传，不传取基础信息中的小程序客服电话.</param>
        /// <param name="specialLicensePicList">特殊资质图片地址列表，逗号分割,.</param>
        /// <param name="templateId">小程序模板ID.</param>
        /// <param name="templateVersion">模板的版本号，如果不填写，则默认用模板当前最新的在架版本.</param>
        /// <param name="versionDesc">小程序版本描述，30-500个字符，一个中文占两个字符，一个英文或者数字占一个字符.</param>
        public AlipayOpenMiniInnerversionBuildauditSubmitModel(string appCategoryIds = default(string), string appDesc = default(string), string appEnglishName = default(string), string appLogo = default(string), string appName = default(string), string appOrigin = default(string), string appSlogan = default(string), string appVersion = default(string), string buildExt = default(string), string bundleId = default(string), string isvAppId = default(string), AuditLicenseInfo licenseInfo = default(AuditLicenseInfo), string miniAppId = default(string), string miniCategoryIds = default(string), string pid = default(string), string regionType = default(string), string screenShotList = default(string), string servicePhone = default(string), string specialLicensePicList = default(string), string templateId = default(string), string templateVersion = default(string), string versionDesc = default(string))
        {
            this.AppCategoryIds = appCategoryIds;
            this.AppDesc = appDesc;
            this.AppEnglishName = appEnglishName;
            this.AppLogo = appLogo;
            this.AppName = appName;
            this.AppOrigin = appOrigin;
            this.AppSlogan = appSlogan;
            this.AppVersion = appVersion;
            this.BuildExt = buildExt;
            this.BundleId = bundleId;
            this.IsvAppId = isvAppId;
            this.LicenseInfo = licenseInfo;
            this.MiniAppId = miniAppId;
            this.MiniCategoryIds = miniCategoryIds;
            this.Pid = pid;
            this.RegionType = regionType;
            this.ScreenShotList = screenShotList;
            this.ServicePhone = servicePhone;
            this.SpecialLicensePicList = specialLicensePicList;
            this.TemplateId = templateId;
            this.TemplateVersion = templateVersion;
            this.VersionDesc = versionDesc;
        }

        /// <summary>
        /// 小程序类目，可不传，不传取基础信息中的小程序类目
        /// </summary>
        /// <value>小程序类目，可不传，不传取基础信息中的小程序类目</value>
        [DataMember(Name = "app_category_ids", EmitDefaultValue = false)]
        public string AppCategoryIds { get; set; }

        /// <summary>
        /// 小程序描述，可不传，不传取基础信息中的小程序描述
        /// </summary>
        /// <value>小程序描述，可不传，不传取基础信息中的小程序描述</value>
        [DataMember(Name = "app_desc", EmitDefaultValue = false)]
        public string AppDesc { get; set; }

        /// <summary>
        /// 小程序在从未上架过版本之前，英文名称是可以修改的，该字段用于在提交审核时候修改小程序英文名称。注意：小程序一旦有过上架版本之后就不可以修改英文名称。
        /// </summary>
        /// <value>小程序在从未上架过版本之前，英文名称是可以修改的，该字段用于在提交审核时候修改小程序英文名称。注意：小程序一旦有过上架版本之后就不可以修改英文名称。</value>
        [DataMember(Name = "app_english_name", EmitDefaultValue = false)]
        public string AppEnglishName { get; set; }

        /// <summary>
        /// 小程序logo，可不传，不传取基础信息中的小程序logo，请调用专用的logo上传接口上传logo文件，并将返回的地址作为本字段传入
        /// </summary>
        /// <value>小程序logo，可不传，不传取基础信息中的小程序logo，请调用专用的logo上传接口上传logo文件，并将返回的地址作为本字段传入</value>
        [DataMember(Name = "app_logo", EmitDefaultValue = false)]
        public string AppLogo { get; set; }

        /// <summary>
        /// 小程序在从未上架过版本之前，中文名称是可以修改的，该字段用于在提交审核时候修改小程序中文名称。注意：小程序一旦有过上架版本之后就不可以修改中文名称。
        /// </summary>
        /// <value>小程序在从未上架过版本之前，中文名称是可以修改的，该字段用于在提交审核时候修改小程序中文名称。注意：小程序一旦有过上架版本之后就不可以修改中文名称。</value>
        [DataMember(Name = "app_name", EmitDefaultValue = false)]
        public string AppName { get; set; }

        /// <summary>
        /// 来源类型，新接入方需要向支付宝申请专用来源，否则不予接入，申请方式请参见接入手册。
        /// </summary>
        /// <value>来源类型，新接入方需要向支付宝申请专用来源，否则不予接入，申请方式请参见接入手册。</value>
        [DataMember(Name = "app_origin", EmitDefaultValue = false)]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 小程序应用简介，一句话描述小程序功能，如果不填默认采用当前小程序应用简介，10~32个字符
        /// </summary>
        /// <value>小程序应用简介，一句话描述小程序功能，如果不填默认采用当前小程序应用简介，10~32个字符</value>
        [DataMember(Name = "app_slogan", EmitDefaultValue = false)]
        public string AppSlogan { get; set; }

        /// <summary>
        /// 小程序版本号
        /// </summary>
        /// <value>小程序版本号</value>
        [DataMember(Name = "app_version", EmitDefaultValue = false)]
        public string AppVersion { get; set; }

        /// <summary>
        /// 构建扩展参数
        /// </summary>
        /// <value>构建扩展参数</value>
        [DataMember(Name = "build_ext", EmitDefaultValue = false)]
        public string BuildExt { get; set; }

        /// <summary>
        /// 端信息
        /// </summary>
        /// <value>端信息</value>
        [DataMember(Name = "bundle_id", EmitDefaultValue = false)]
        public string BundleId { get; set; }

        /// <summary>
        /// 三方应用ID
        /// </summary>
        /// <value>三方应用ID</value>
        [DataMember(Name = "isv_app_id", EmitDefaultValue = false)]
        public string IsvAppId { get; set; }

        /// <summary>
        /// Gets or Sets LicenseInfo
        /// </summary>
        [DataMember(Name = "license_info", EmitDefaultValue = false)]
        public AuditLicenseInfo LicenseInfo { get; set; }

        /// <summary>
        /// 小程序ID，特殊场景专用，普通业务方无需关注该参数。
        /// </summary>
        /// <value>小程序ID，特殊场景专用，普通业务方无需关注该参数。</value>
        [DataMember(Name = "mini_app_id", EmitDefaultValue = false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 新小程序前台类目，格式为 第一个一级类目_第一个二级类目;第二个一级类目_第二个二级类目_第二个三级类目，详细类目可以通过 https://docs.open.alipay.com/api_49/alipay.open.mini.category.query接口查询mini_category_list，如果不填默认采用当前小程序应用类目。使用默认应用类目后不需要再次上传营业执照号、营业执照名、营业执照截图、营业执照有效期。使用后不再读取app_category_ids值，老前台类目将废弃
        /// </summary>
        /// <value>新小程序前台类目，格式为 第一个一级类目_第一个二级类目;第二个一级类目_第二个二级类目_第二个三级类目，详细类目可以通过 https://docs.open.alipay.com/api_49/alipay.open.mini.category.query接口查询mini_category_list，如果不填默认采用当前小程序应用类目。使用默认应用类目后不需要再次上传营业执照号、营业执照名、营业执照截图、营业执照有效期。使用后不再读取app_category_ids值，老前台类目将废弃</value>
        [DataMember(Name = "mini_category_ids", EmitDefaultValue = false)]
        public string MiniCategoryIds { get; set; }

        /// <summary>
        /// 小程序开发者ID，可不传，不传取基础信息中的小程序开发者ID
        /// </summary>
        /// <value>小程序开发者ID，可不传，不传取基础信息中的小程序开发者ID</value>
        [DataMember(Name = "pid", EmitDefaultValue = false)]
        public string Pid { get; set; }

        /// <summary>
        /// 服务区域类型,可不传，不传取基础信息中的小程序服务区域类型
        /// </summary>
        /// <value>服务区域类型,可不传，不传取基础信息中的小程序服务区域类型</value>
        [DataMember(Name = "region_type", EmitDefaultValue = false)]
        public string RegionType { get; set; }

        /// <summary>
        /// 版本截图，最少2张，最多5张，必传
        /// </summary>
        /// <value>版本截图，最少2张，最多5张，必传</value>
        [DataMember(Name = "screen_shot_list", EmitDefaultValue = false)]
        public string ScreenShotList { get; set; }

        /// <summary>
        /// 客服电话，可不传，不传取基础信息中的小程序客服电话
        /// </summary>
        /// <value>客服电话，可不传，不传取基础信息中的小程序客服电话</value>
        [DataMember(Name = "service_phone", EmitDefaultValue = false)]
        public string ServicePhone { get; set; }

        /// <summary>
        /// 特殊资质图片地址列表，逗号分割,
        /// </summary>
        /// <value>特殊资质图片地址列表，逗号分割,</value>
        [DataMember(Name = "special_license_pic_list", EmitDefaultValue = false)]
        public string SpecialLicensePicList { get; set; }

        /// <summary>
        /// 小程序模板ID
        /// </summary>
        /// <value>小程序模板ID</value>
        [DataMember(Name = "template_id", EmitDefaultValue = false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 模板的版本号，如果不填写，则默认用模板当前最新的在架版本
        /// </summary>
        /// <value>模板的版本号，如果不填写，则默认用模板当前最新的在架版本</value>
        [DataMember(Name = "template_version", EmitDefaultValue = false)]
        public string TemplateVersion { get; set; }

        /// <summary>
        /// 小程序版本描述，30-500个字符，一个中文占两个字符，一个英文或者数字占一个字符
        /// </summary>
        /// <value>小程序版本描述，30-500个字符，一个中文占两个字符，一个英文或者数字占一个字符</value>
        [DataMember(Name = "version_desc", EmitDefaultValue = false)]
        public string VersionDesc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniInnerversionBuildauditSubmitModel {\n");
            sb.Append("  AppCategoryIds: ").Append(AppCategoryIds).Append("\n");
            sb.Append("  AppDesc: ").Append(AppDesc).Append("\n");
            sb.Append("  AppEnglishName: ").Append(AppEnglishName).Append("\n");
            sb.Append("  AppLogo: ").Append(AppLogo).Append("\n");
            sb.Append("  AppName: ").Append(AppName).Append("\n");
            sb.Append("  AppOrigin: ").Append(AppOrigin).Append("\n");
            sb.Append("  AppSlogan: ").Append(AppSlogan).Append("\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  BuildExt: ").Append(BuildExt).Append("\n");
            sb.Append("  BundleId: ").Append(BundleId).Append("\n");
            sb.Append("  IsvAppId: ").Append(IsvAppId).Append("\n");
            sb.Append("  LicenseInfo: ").Append(LicenseInfo).Append("\n");
            sb.Append("  MiniAppId: ").Append(MiniAppId).Append("\n");
            sb.Append("  MiniCategoryIds: ").Append(MiniCategoryIds).Append("\n");
            sb.Append("  Pid: ").Append(Pid).Append("\n");
            sb.Append("  RegionType: ").Append(RegionType).Append("\n");
            sb.Append("  ScreenShotList: ").Append(ScreenShotList).Append("\n");
            sb.Append("  ServicePhone: ").Append(ServicePhone).Append("\n");
            sb.Append("  SpecialLicensePicList: ").Append(SpecialLicensePicList).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  TemplateVersion: ").Append(TemplateVersion).Append("\n");
            sb.Append("  VersionDesc: ").Append(VersionDesc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlipayOpenMiniInnerversionBuildauditSubmitModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniInnerversionBuildauditSubmitModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniInnerversionBuildauditSubmitModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniInnerversionBuildauditSubmitModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppCategoryIds == input.AppCategoryIds ||
                    (this.AppCategoryIds != null &&
                    this.AppCategoryIds.Equals(input.AppCategoryIds))
                ) && 
                (
                    this.AppDesc == input.AppDesc ||
                    (this.AppDesc != null &&
                    this.AppDesc.Equals(input.AppDesc))
                ) && 
                (
                    this.AppEnglishName == input.AppEnglishName ||
                    (this.AppEnglishName != null &&
                    this.AppEnglishName.Equals(input.AppEnglishName))
                ) && 
                (
                    this.AppLogo == input.AppLogo ||
                    (this.AppLogo != null &&
                    this.AppLogo.Equals(input.AppLogo))
                ) && 
                (
                    this.AppName == input.AppName ||
                    (this.AppName != null &&
                    this.AppName.Equals(input.AppName))
                ) && 
                (
                    this.AppOrigin == input.AppOrigin ||
                    (this.AppOrigin != null &&
                    this.AppOrigin.Equals(input.AppOrigin))
                ) && 
                (
                    this.AppSlogan == input.AppSlogan ||
                    (this.AppSlogan != null &&
                    this.AppSlogan.Equals(input.AppSlogan))
                ) && 
                (
                    this.AppVersion == input.AppVersion ||
                    (this.AppVersion != null &&
                    this.AppVersion.Equals(input.AppVersion))
                ) && 
                (
                    this.BuildExt == input.BuildExt ||
                    (this.BuildExt != null &&
                    this.BuildExt.Equals(input.BuildExt))
                ) && 
                (
                    this.BundleId == input.BundleId ||
                    (this.BundleId != null &&
                    this.BundleId.Equals(input.BundleId))
                ) && 
                (
                    this.IsvAppId == input.IsvAppId ||
                    (this.IsvAppId != null &&
                    this.IsvAppId.Equals(input.IsvAppId))
                ) && 
                (
                    this.LicenseInfo == input.LicenseInfo ||
                    (this.LicenseInfo != null &&
                    this.LicenseInfo.Equals(input.LicenseInfo))
                ) && 
                (
                    this.MiniAppId == input.MiniAppId ||
                    (this.MiniAppId != null &&
                    this.MiniAppId.Equals(input.MiniAppId))
                ) && 
                (
                    this.MiniCategoryIds == input.MiniCategoryIds ||
                    (this.MiniCategoryIds != null &&
                    this.MiniCategoryIds.Equals(input.MiniCategoryIds))
                ) && 
                (
                    this.Pid == input.Pid ||
                    (this.Pid != null &&
                    this.Pid.Equals(input.Pid))
                ) && 
                (
                    this.RegionType == input.RegionType ||
                    (this.RegionType != null &&
                    this.RegionType.Equals(input.RegionType))
                ) && 
                (
                    this.ScreenShotList == input.ScreenShotList ||
                    (this.ScreenShotList != null &&
                    this.ScreenShotList.Equals(input.ScreenShotList))
                ) && 
                (
                    this.ServicePhone == input.ServicePhone ||
                    (this.ServicePhone != null &&
                    this.ServicePhone.Equals(input.ServicePhone))
                ) && 
                (
                    this.SpecialLicensePicList == input.SpecialLicensePicList ||
                    (this.SpecialLicensePicList != null &&
                    this.SpecialLicensePicList.Equals(input.SpecialLicensePicList))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.TemplateVersion == input.TemplateVersion ||
                    (this.TemplateVersion != null &&
                    this.TemplateVersion.Equals(input.TemplateVersion))
                ) && 
                (
                    this.VersionDesc == input.VersionDesc ||
                    (this.VersionDesc != null &&
                    this.VersionDesc.Equals(input.VersionDesc))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AppCategoryIds != null)
                {
                    hashCode = (hashCode * 59) + this.AppCategoryIds.GetHashCode();
                }
                if (this.AppDesc != null)
                {
                    hashCode = (hashCode * 59) + this.AppDesc.GetHashCode();
                }
                if (this.AppEnglishName != null)
                {
                    hashCode = (hashCode * 59) + this.AppEnglishName.GetHashCode();
                }
                if (this.AppLogo != null)
                {
                    hashCode = (hashCode * 59) + this.AppLogo.GetHashCode();
                }
                if (this.AppName != null)
                {
                    hashCode = (hashCode * 59) + this.AppName.GetHashCode();
                }
                if (this.AppOrigin != null)
                {
                    hashCode = (hashCode * 59) + this.AppOrigin.GetHashCode();
                }
                if (this.AppSlogan != null)
                {
                    hashCode = (hashCode * 59) + this.AppSlogan.GetHashCode();
                }
                if (this.AppVersion != null)
                {
                    hashCode = (hashCode * 59) + this.AppVersion.GetHashCode();
                }
                if (this.BuildExt != null)
                {
                    hashCode = (hashCode * 59) + this.BuildExt.GetHashCode();
                }
                if (this.BundleId != null)
                {
                    hashCode = (hashCode * 59) + this.BundleId.GetHashCode();
                }
                if (this.IsvAppId != null)
                {
                    hashCode = (hashCode * 59) + this.IsvAppId.GetHashCode();
                }
                if (this.LicenseInfo != null)
                {
                    hashCode = (hashCode * 59) + this.LicenseInfo.GetHashCode();
                }
                if (this.MiniAppId != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppId.GetHashCode();
                }
                if (this.MiniCategoryIds != null)
                {
                    hashCode = (hashCode * 59) + this.MiniCategoryIds.GetHashCode();
                }
                if (this.Pid != null)
                {
                    hashCode = (hashCode * 59) + this.Pid.GetHashCode();
                }
                if (this.RegionType != null)
                {
                    hashCode = (hashCode * 59) + this.RegionType.GetHashCode();
                }
                if (this.ScreenShotList != null)
                {
                    hashCode = (hashCode * 59) + this.ScreenShotList.GetHashCode();
                }
                if (this.ServicePhone != null)
                {
                    hashCode = (hashCode * 59) + this.ServicePhone.GetHashCode();
                }
                if (this.SpecialLicensePicList != null)
                {
                    hashCode = (hashCode * 59) + this.SpecialLicensePicList.GetHashCode();
                }
                if (this.TemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateId.GetHashCode();
                }
                if (this.TemplateVersion != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateVersion.GetHashCode();
                }
                if (this.VersionDesc != null)
                {
                    hashCode = (hashCode * 59) + this.VersionDesc.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
