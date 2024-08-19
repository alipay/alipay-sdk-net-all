using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: antfortune.stock.stockinstops.backflow.upload
    /// </summary>
    public class AntfortuneStockStockinstopsBackflowUploadRequest : IAopUploadRequest<AntfortuneStockStockinstopsBackflowUploadResponse>
    {
        /// <summary>
        /// 上传数据的压缩算法
        /// </summary>
        public string CompressType { get; set; }

        /// <summary>
        /// 上传文件的二进制流
        /// </summary>
        public FileItem FileContent { get; set; }

        /// <summary>
        /// forward服务器的域名信息
        /// </summary>
        public string ForwardHost { get; set; }

        /// <summary>
        /// forward所在机房信息
        /// </summary>
        public string ForwardRoom { get; set; }

        /// <summary>
        /// forward发送的时间，单位为秒
        /// </summary>
        public string ForwardTime { get; set; }

        /// <summary>
        /// forward链路追踪Id
        /// </summary>
        public string ForwardTrace { get; set; }

        /// <summary>
        /// forward所在环境信息
        /// </summary>
        public string ForwardZone { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        public string InstId { get; set; }

        /// <summary>
        /// 业务数据类型
        /// </summary>
        public string MsgType { get; set; }

        #region IAopRequest Members
		private bool needEncrypt=false;
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

		public void SetApiVersion(string apiVersion){
            this.apiVersion=apiVersion;
        }

        public string GetApiVersion(){
            return this.apiVersion;
        }

        public string GetApiName()
        {
            return "antfortune.stock.stockinstops.backflow.upload";
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
            parameters.Add("compress_type", this.CompressType);
            parameters.Add("forward_host", this.ForwardHost);
            parameters.Add("forward_room", this.ForwardRoom);
            parameters.Add("forward_time", this.ForwardTime);
            parameters.Add("forward_trace", this.ForwardTrace);
            parameters.Add("forward_zone", this.ForwardZone);
            parameters.Add("inst_id", this.InstId);
            parameters.Add("msg_type", this.MsgType);
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

        #region IAopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("file_content", this.FileContent);
            return parameters;
        }

        #endregion
    }
}
