using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ebpp.prodmode.agreement.upload
    /// </summary>
    public class AlipayEbppProdmodeAgreementUploadRequest : IAopUploadRequest<AlipayEbppProdmodeAgreementUploadResponse>
    {
        /// <summary>
        /// 操作者名称
        /// </summary>
        public string OperatorName { get; set; }

        /// <summary>
        /// 创建批次任务ID，生成结果需要外部商户邦道提交批次水燃入驻信息，调用alipay.ebpp.isv.prodmode.create入驻信息开放接口，缴费端接收请求，创建批次任务，生成任务ID，通过创建任务接口返回给邦道。
        /// </summary>
        public string TaskId { get; set; }

        /// <summary>
        /// byte[]数组类型值，提供邦道授权函协议上传，上传文件格式必须是.rar或.zip压缩文件。
        /// </summary>
        public FileItem UploadFile { get; set; }

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
            return "alipay.ebpp.prodmode.agreement.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("operator_name", this.OperatorName);
            parameters.Add("task_id", this.TaskId);
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
            parameters.Add("upload_file", this.UploadFile);
            return parameters;
        }

        #endregion
    }
}
