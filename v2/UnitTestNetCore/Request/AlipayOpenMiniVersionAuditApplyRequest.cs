using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.mini.version.audit.apply
    /// </summary>
    public class AlipayOpenMiniVersionAuditApplyRequest : IAopUploadRequest<AlipayOpenMiniVersionAuditApplyResponse>
    {
        /// <summary>
        /// 小程序类目，格式为 第一个一级类目_第一个二级类目;第二个一级类目_第二个二级类目，详细类目可以通过  https://docs.open.alipay.com/api_49/alipay.open.mini.category.query接口查询，如果不填默认采用当前小程序应用类目。使用默认应用类目后不需要再次上传营业执照号、营业执照名、营业执照截图、营业执照有效期。
        /// </summary>
        public string AppCategoryIds { get; set; }

        /// <summary>
        /// 小程序应用描述，20-200个字，如果不填默认采用当前小程序的应用描述
        /// </summary>
        public string AppDesc { get; set; }

        /// <summary>
        /// 小程序应用英文名称，如果不填默认采用当前小程序应用英文名称，3～30个字符；小程序英文名称只允许英文和数字
        /// </summary>
        public string AppEnglishName { get; set; }

        /// <summary>
        /// 小程序logo图标，图片格式必须为：png、jpeg、jpg，建议上传像素为180*180，如果不填默认采用当前小程序应用logo图标;logo图片最大256KB
        /// </summary>
        public FileItem AppLogo { get; set; }

        /// <summary>
        /// 小程序应用名称，如果不填默认采用当前小程序应用名称 小程序中文名称限制为3-20个字符 小程序中文名称只能包含中文、数字、英文及下划线
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 小程序应用简介，一句话描述小程序功能，如果不填默认采用当前小程序应用简介，10~32个字符
        /// </summary>
        public string AppSlogan { get; set; }

        /// <summary>
        /// 小程序版本号;请在开发版上执行提交审核操作
        /// </summary>
        public string AppVersion { get; set; }

        /// <summary>
        /// 小程序投放的端参数，例如投放到支付宝钱包是支付宝端。该参数可选，默认支付宝端 com.alipay.alipaywallet:支付宝端
        /// </summary>
        public string BundleId { get; set; }

        /// <summary>
        /// 第五张营业执照照片，不能超过4MB，图片格式只支持jpg，png，部分小程序类目需要提交，参照https://opendocs.alipay.com/mini/operation/material中是否需要营业执照信息，如果不填默认采用当前小程序第五张营业执照照片;最大宽度2160，最大高度3840
        /// </summary>
        public FileItem FifthLicensePic { get; set; }

        /// <summary>
        /// 小程序第五张应用截图，不能超过4MB，图片格式只支持jpg，png;小程序截图数量最小为2，最大为5 最大宽度2160，最大高度3840
        /// </summary>
        public FileItem FifthScreenShot { get; set; }

        /// <summary>
        /// 第一张营业执照照片，不能超过4MB，图片格式只支持jpg，png，部分小程序类目需要提交，参照https://opendocs.alipay.com/mini/operation/material中是否需要营业执照信息，如果不填默认采用当前小程序第一张营业执照照片;最大宽度2160，最大高度3840
        /// </summary>
        public FileItem FirstLicensePic { get; set; }

        /// <summary>
        /// 实例化的小程序可以不用传第一张应用截图，小程序第一张应用截图，不能超过4MB，图片格式只支持jpg，png;小程序截图数量最小为2，最大为5 最大宽度2160，最大高度3840
        /// </summary>
        public FileItem FirstScreenShot { get; set; }

        /// <summary>
        /// 第一张特殊资质图片，不能超过4MB，图片格式只支持jpg、png、jepg，部分小程序类目需要提交，参照https://opendocs.alipay.com/mini/operation/material 中是否需要特殊资质，如果不填默认采用当前小程序第一张特殊资质
        /// </summary>
        public FileItem FirstSpecialLicensePic { get; set; }

        /// <summary>
        /// 第四张营业执照照片，不能超过4MB，图片格式只支持jpg，png，部分小程序类目需要提交，参照https://opendocs.alipay.com/mini/operation/material中是否需要营业执照信息，如果不填默认采用当前小程序第四张营业执照照片;最大宽度2160，最大高度3840
        /// </summary>
        public FileItem FourthLicensePic { get; set; }

        /// <summary>
        /// 小程序第四张应用截图，不能超过4MB，图片格式只支持jpg，png;小程序截图数量最小为2，最大为5 最大宽度2160，最大高度3840
        /// </summary>
        public FileItem FourthScreenShot { get; set; }

        /// <summary>
        /// 营业执照名称，部分小程序类目需要提交，参照https://opendocs.alipay.com/mini/operation/material中是否需要营业执照信息，如果不填类目采用当前小程序应用营业执照名称。
        /// </summary>
        public string LicenseName { get; set; }

        /// <summary>
        /// 营业执照号，部分小程序类目需要提交，参照https://opendocs.alipay.com/mini/operation/material中是否需要营业执照信息，如果不填默认采用当前小程序应用营业执照号。
        /// </summary>
        public string LicenseNo { get; set; }

        /// <summary>
        /// 营业执照有效期，格式为yyyy-MM-dd，9999-12-31表示长期，部分小程序类目需要提交，参照https://opendocs.alipay.com/mini/operation/material中是否需要营业执照信息，如果不填默认采用当前小程序营业执照有效期
        /// </summary>
        public string LicenseValidDate { get; set; }

        /// <summary>
        /// 小程序备注;小程序备注最多500字符
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 新小程序前台类目，格式为 第一个一级类目_第一个二级类目;第二个一级类目_第二个二级类目_第二个三级类目，详细类目可以通过 https://docs.open.alipay.com/api_49/alipay.open.mini.category.query接口查询mini_category_list，如果不填默认采用当前小程序应用类目。使用默认应用类目后不需要再次上传营业执照号、营业执照名、营业执照截图、营业执照有效期。使用后不再读取app_category_ids值，老前台类目将废弃
        /// </summary>
        public string MiniCategoryIds { get; set; }

        /// <summary>
        /// 门头照图片，部分小程序类目需要提交，参照https://opendocs.alipay.com/mini/operation/material中是否需要营业执照信息，如果不填默认采用当前小程序门头照图片;门头照支持扩展名为jpg, png;门头照最大4MB，宽度2160，高度3840
        /// </summary>
        public FileItem OutDoorPic { get; set; }

        /// <summary>
        /// 小程序服务区域类型，GLOBAL-全球，CHINA-中国，LOCATION-指定区域
        /// </summary>
        public string RegionType { get; set; }

        /// <summary>
        /// 第二张营业执照照片，不能超过4MB，图片格式只支持jpg，png，部分小程序类目需要提交，参照https://opendocs.alipay.com/mini/operation/material中是否需要营业执照信息，如果不填默认采用当前小程序第二张营业执照照片;最大宽度2160，最大高度3840
        /// </summary>
        public FileItem SecondLicensePic { get; set; }

        /// <summary>
        /// 实例化的小程序可以不用传第二张应用截图，小程序第二张应用截图，不能超过4MB，图片格式只支持jpg，png;小程序截图数量最小为2，最大为5 最大宽度2160，最大高度3840
        /// </summary>
        public FileItem SecondScreenShot { get; set; }

        /// <summary>
        /// 第二张特殊资质图片文件，不能超过4MB，图片格式只支持jpg、png、jepg，部分小程序类目需要提交，参照https://opendocs.alipay.com/mini/operation/material 中是否需要特殊资质，如果不填默认采用当前小程序第二张特殊资质图片
        /// </summary>
        public FileItem SecondSpecialLicensePic { get; set; }

        /// <summary>
        /// 小程序客服邮箱，如果不填默认采用当前小程序的应用客服邮箱;小程序客服电话和邮箱至少输入一个
        /// </summary>
        public string ServiceEmail { get; set; }

        /// <summary>
        /// 小程序客服电话，如果不填默认采用当前小程序的应用客服电话;小程序客服电话和邮箱至少输入一个 只允许包含数字和-，5-30个字符
        /// </summary>
        public string ServicePhone { get; set; }

        /// <summary>
        /// 省市区信息，当区域类型为LOCATION时，不能为空，province_code不能为空，当填写city_code时，province_code不能为空，当填写area_code时，province_code和city_code不能为空。只填province_code时，该省全部选择；province_code和city_code都填时，该市全部选择。province_code，city_code和area_code都填时，该县全部选择。
        /// </summary>
        public List<RegionInfo> ServiceRegionInfo { get; set; }

        /// <summary>
        /// 测试账号
        /// </summary>
        public string TestAccout { get; set; }

        /// <summary>
        /// 测试附件，请上传10M以内附件，支持格式zip,rar
        /// </summary>
        public FileItem TestFileName { get; set; }

        /// <summary>
        /// 测试账号密码
        /// </summary>
        public string TestPassword { get; set; }

        /// <summary>
        /// 第三张营业执照照片，不能超过4MB，图片格式只支持jpg，png，部分小程序类目需要提交，参照https://opendocs.alipay.com/mini/operation/material中是否需要营业执照信息，如果不填默认采用当前小程序第三张营业执照照片;最大宽度2160，最大高度3840
        /// </summary>
        public FileItem ThirdLicensePic { get; set; }

        /// <summary>
        /// 小程序第三张应用截图，不能超过4MB，图片格式只支持jpg，png;小程序截图数量最小为2，最大为5 最大宽度2160，最大高度3840
        /// </summary>
        public FileItem ThirdScreenShot { get; set; }

        /// <summary>
        /// 第三张特殊资质图片文件，不能超过4MB，图片格式只支持jpg、png、jepg，部分小程序类目需要提交，参照https://opendocs.alipay.com/mini/operation/material中是否需要特殊资质，如果不填默认采用当前小程序第三张特殊资质
        /// </summary>
        public FileItem ThirdSpecialLicensePic { get; set; }

        /// <summary>
        /// 小程序版本描述，30-500个字符
        /// </summary>
        public string VersionDesc { get; set; }

        #region IAopRequest Members
		private bool needEncrypt=false;
		private string apiVersion = "1.0";
		private string terminalType;
		private string terminalInfo;
        private string prodCode;
		private string notifyUrl;
        private string returnUrl;
		private AopObject bizModel;

    	 public void SetNeedEncrypt(bool needEncrypt){
             this.needEncrypt=needEncrypt;
        }

        public bool GetNeedEncrypt(){

            return this.needEncrypt;
        }

		public void SetNotifyUrl(string notifyUrl){
            this.notifyUrl = notifyUrl;
        }

        public string GetNotifyUrl(){
            return this.notifyUrl;
        }

        public void SetReturnUrl(string returnUrl){
            this.returnUrl = returnUrl;
        }

        public string GetReturnUrl(){
            return this.returnUrl;
        }

		public void SetTerminalType(String terminalType){
			this.terminalType=terminalType;
		}

    	public string GetTerminalType(){
    		return this.terminalType;
    	}

    	public void SetTerminalInfo(String terminalInfo){
    		this.terminalInfo=terminalInfo;
    	}

    	public string GetTerminalInfo(){
    		return this.terminalInfo;
    	}

        public void SetProdCode(String prodCode){
            this.prodCode=prodCode;
        }

        public string GetProdCode(){
            return this.prodCode;
        }

		public void SetApiVersion(string apiVersion){
            this.apiVersion=apiVersion;
        }

        public string GetApiVersion(){
            return this.apiVersion;
        }

        public string GetApiName()
        {
            return "alipay.open.mini.version.audit.apply";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("app_category_ids", this.AppCategoryIds);
            parameters.Add("app_desc", this.AppDesc);
            parameters.Add("app_english_name", this.AppEnglishName);
            parameters.Add("app_name", this.AppName);
            parameters.Add("app_slogan", this.AppSlogan);
            parameters.Add("app_version", this.AppVersion);
            parameters.Add("bundle_id", this.BundleId);
            parameters.Add("license_name", this.LicenseName);
            parameters.Add("license_no", this.LicenseNo);
            parameters.Add("license_valid_date", this.LicenseValidDate);
            parameters.Add("memo", this.Memo);
            parameters.Add("mini_category_ids", this.MiniCategoryIds);
            parameters.Add("region_type", this.RegionType);
            parameters.Add("service_email", this.ServiceEmail);
            parameters.Add("service_phone", this.ServicePhone);
            parameters.Add("service_region_info", this.ServiceRegionInfo);
            parameters.Add("test_accout", this.TestAccout);
            parameters.Add("test_password", this.TestPassword);
            parameters.Add("version_desc", this.VersionDesc);
            return parameters;
        }
		
		public AopObject GetBizModel()
        {
            return this.bizModel;
        }

        public void SetBizModel(AopObject bizModel)
        {
            this.bizModel = bizModel;
        }

        #endregion

        #region IAopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("app_logo", this.AppLogo);
            parameters.Add("fifth_license_pic", this.FifthLicensePic);
            parameters.Add("fifth_screen_shot", this.FifthScreenShot);
            parameters.Add("first_license_pic", this.FirstLicensePic);
            parameters.Add("first_screen_shot", this.FirstScreenShot);
            parameters.Add("first_special_license_pic", this.FirstSpecialLicensePic);
            parameters.Add("fourth_license_pic", this.FourthLicensePic);
            parameters.Add("fourth_screen_shot", this.FourthScreenShot);
            parameters.Add("out_door_pic", this.OutDoorPic);
            parameters.Add("second_license_pic", this.SecondLicensePic);
            parameters.Add("second_screen_shot", this.SecondScreenShot);
            parameters.Add("second_special_license_pic", this.SecondSpecialLicensePic);
            parameters.Add("test_file_name", this.TestFileName);
            parameters.Add("third_license_pic", this.ThirdLicensePic);
            parameters.Add("third_screen_shot", this.ThirdScreenShot);
            parameters.Add("third_special_license_pic", this.ThirdSpecialLicensePic);
            return parameters;
        }

        #endregion
    }
}
