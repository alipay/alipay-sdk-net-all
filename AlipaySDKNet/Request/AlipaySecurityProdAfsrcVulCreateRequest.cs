using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.security.prod.afsrc.vul.create
    /// </summary>
    public class AlipaySecurityProdAfsrcVulCreateRequest : IAopUploadRequest<AlipaySecurityProdAfsrcVulCreateResponse>
    {
        /// <summary>
        /// 漏洞附件
        /// </summary>
        public FileItem Attachment { get; set; }

        /// <summary>
        /// 漏洞所属业务
        /// </summary>
        public Nullable<long> Business { get; set; }

        /// <summary>
        /// 漏洞所属公司
        /// </summary>
        public Nullable<long> Company { get; set; }

        /// <summary>
        /// 漏洞详情
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// HavanaId(淘宝uid)
        /// </summary>
        public Nullable<long> Hid { get; set; }

        /// <summary>
        /// 用户上报漏洞等级
        /// </summary>
        public Nullable<long> Level { get; set; }

        /// <summary>
        /// 白帽子提交漏洞时填写的手机号
        /// </summary>
        public string MobilePhone { get; set; }

        /// <summary>
        /// 漏洞名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 漏洞状态
        /// </summary>
        public Nullable<long> Status { get; set; }

        /// <summary>
        /// 漏洞提交时间
        /// </summary>
        public string SubmitTime { get; set; }

        /// <summary>
        /// 子平台漏洞一级类型 ID
        /// </summary>
        public string TypeSubFirstId { get; set; }

        /// <summary>
        /// 一级漏洞类型名称
        /// </summary>
        public string TypeSubFirstName { get; set; }

        /// <summary>
        /// 子平台漏洞二级类型 ID
        /// </summary>
        public string TypeSubSecondId { get; set; }

        /// <summary>
        /// 二级漏洞类型名称
        /// </summary>
        public string TypeSubSecondName { get; set; }

        /// <summary>
        /// 统一平台漏洞一级类型 ID
        /// </summary>
        public Nullable<long> TypeUnionFirstId { get; set; }

        /// <summary>
        /// 统一平台漏洞二级类型 ID
        /// </summary>
        public Nullable<long> TypeUnionSecondId { get; set; }

        /// <summary>
        /// 漏洞 URL
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 支付宝 ID
        /// </summary>
        public string UserId { get; set; }

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
            return "alipay.security.prod.afsrc.vul.create";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("business", this.Business);
            parameters.Add("company", this.Company);
            parameters.Add("detail", this.Detail);
            parameters.Add("hid", this.Hid);
            parameters.Add("level", this.Level);
            parameters.Add("mobile_phone", this.MobilePhone);
            parameters.Add("name", this.Name);
            parameters.Add("nick", this.Nick);
            parameters.Add("status", this.Status);
            parameters.Add("submit_time", this.SubmitTime);
            parameters.Add("type_sub_first_id", this.TypeSubFirstId);
            parameters.Add("type_sub_first_name", this.TypeSubFirstName);
            parameters.Add("type_sub_second_id", this.TypeSubSecondId);
            parameters.Add("type_sub_second_name", this.TypeSubSecondName);
            parameters.Add("type_union_first_id", this.TypeUnionFirstId);
            parameters.Add("type_union_second_id", this.TypeUnionSecondId);
            parameters.Add("url", this.Url);
            parameters.Add("user_id", this.UserId);
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
            parameters.Add("attachment", this.Attachment);
            return parameters;
        }

        #endregion
    }
}
