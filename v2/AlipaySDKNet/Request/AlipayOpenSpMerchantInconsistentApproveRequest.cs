using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.sp.merchant.inconsistent.approve
    /// </summary>
    public class AlipayOpenSpMerchantInconsistentApproveRequest : IAopRequest<AlipayOpenSpMerchantInconsistentApproveResponse>
    {
        /// <summary>
        /// 身份证背面照，图片文件大小在 50K-5M 之间，不限制长宽，支持 png、bmp、gif、jpg、jpeg 格式。 请传入<a href="https://opendocs.alipay.com/apis/01ea4t">alipay.open.sp.image.upload</a>(图片上传接口) 返回的 image_id。
        /// </summary>
        public string BackCard { get; set; }

        /// <summary>
        /// 实际经营人承诺函照片，要求证件文本信息清晰可见，图片文件大小在 50K-5M 之间，不限制长宽，支持 png、bmp、gif、jpg、jpeg 格式。 请传入<a href="https://opendocs.alipay.com/apis/01ea4t">alipay.open.sp.image.upload</a>(图片上传接口) 返回的 image_id。 该资质是否必传请参见报名资质要求。
        /// </summary>
        public string CommitmentLetter { get; set; }

        /// <summary>
        /// 身份证正面照，要求证件文本信息清晰可见，图片文件大小在 50K-5M 之间，不限制长宽，支持 png、bmp、gif、jpg、jpeg 格式. 请传<a href="https://opendocs.alipay.com/apis/01ea4t">alipay.open.sp.image.upload</a>(图片上传接口) 返回的 image_id。
        /// </summary>
        public string FrontCard { get; set; }

        /// <summary>
        /// 手持营业执照合照，要求证件文本信息清晰可见，图片文件大小在 50K-5M 之间，不限制长宽，支持 png、bmp、gif、jpg、jpeg 格式。 请传入<a href="https://opendocs.alipay.com/apis/01ea4t">alipay.open.sp.image.upload</a>(图片上传接口) 返回的 image_id。 该资质是否必传请参见报名资质要求。
        /// </summary>
        public string HandheldBusinessLicense { get; set; }

        /// <summary>
        /// 手持身份证合照，要求证件文本信息清晰可见，图片文件大小在 50K-5M 之间，不限制长宽，支持 png、bmp、gif、jpg、jpeg 格式。 请传入<a href="https://opendocs.alipay.com/apis/01ea4t">alipay.open.sp.image.upload</a>(图片上传接口) 返回的 image_id。 该资质是否必传请参见报名资质要求。
        /// </summary>
        public string HandheldCard { get; set; }

        /// <summary>
        /// 服务优选商品编码
        /// </summary>
        public string ItemCode { get; set; }

        /// <summary>
        /// 商家pid
        /// </summary>
        public string MerchantPid { get; set; }

        /// <summary>
        /// 商家小程序appId
        /// </summary>
        public string MiniAppid { get; set; }

        /// <summary>
        /// 外部业务号，需不重复
        /// </summary>
        public string OutBizNo { get; set; }

        /// <summary>
        /// 推广服务商(S2)pid
        /// </summary>
        public string PromotorPid { get; set; }

        #region IAopRequest Members
        private bool  needEncrypt=false;
        private string apiVersion = "1.0";
	    private string terminalType;
	    private string terminalInfo;
        private string prodCode;
	    private string notifyUrl;
        private string returnUrl;
	    private AopObject bizModel;
        private Dictionary<string, string> udfParams; //add user-defined text parameters

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

        public string GetApiName()
        {
            return "alipay.open.sp.merchant.inconsistent.approve";
        }

        public void SetApiVersion(string apiVersion){
            this.apiVersion=apiVersion;
        }

        public string GetApiVersion(){
            return this.apiVersion;
        }

        public void PutOtherTextParam(string key, string value) 
        {
            if(this.udfParams == null) 
            {
                this.udfParams = new Dictionary<string, string>();
            }
            this.udfParams.Add(key, value);
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("back_card", this.BackCard);
            parameters.Add("commitment_letter", this.CommitmentLetter);
            parameters.Add("front_card", this.FrontCard);
            parameters.Add("handheld_business_license", this.HandheldBusinessLicense);
            parameters.Add("handheld_card", this.HandheldCard);
            parameters.Add("item_code", this.ItemCode);
            parameters.Add("merchant_pid", this.MerchantPid);
            parameters.Add("mini_appid", this.MiniAppid);
            parameters.Add("out_biz_no", this.OutBizNo);
            parameters.Add("promotor_pid", this.PromotorPid);
            if(udfParams != null) 
            {
                parameters.AddAll(this.udfParams);
            }
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
    }
}
