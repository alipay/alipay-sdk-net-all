using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowTraderesultQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsFreightflowTraderesultQueryModel : AopObject
    {
        /// <summary>
        /// 如果biz_scene是转账场景，则传入转账申请时候的幂等号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 转账 ："TRANSFER", 调拨："ALLOCATE"
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 物流公司编码
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 银行管理模式。 本期： ANT_MYBANK(网商银行模式)
        /// </summary>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 网商银行应用id,当mode为ANT_MYBANK时由网商提供给商户
        /// </summary>
        [XmlElement("mybank_app_id")]
        public string MybankAppId { get; set; }

        /// <summary>
        /// 发起网商操作(如转账)时网商返回的操作单号
        /// </summary>
        [XmlElement("operate_no")]
        public string OperateNo { get; set; }

        /// <summary>
        /// 合作方机构号。 如果mode为网商银行，则为网商银行分配。 如果mode为浦发银行，则为浦发APP对应的X-SPDB-Client-ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 浦发银行母户户号
        /// </summary>
        [XmlElement("spdb_parent_account_no")]
        public string SpdbParentAccountNo { get; set; }

        /// <summary>
        /// 浦发银行特定流水号
        /// </summary>
        [XmlElement("spdb_seq_no")]
        public FreigtFlowSpdbBizSeqNo SpdbSeqNo { get; set; }

        /// <summary>
        /// 浦发银行特定场景参数,当mode=SPDB时必选
        /// </summary>
        [XmlElement("spdb_spec_params")]
        public FreightFlowSpdbSpecParams SpdbSpecParams { get; set; }

        /// <summary>
        /// 02-客户出金 06-会员调拨(子户互转)
        /// </summary>
        [XmlElement("spdb_tran_tp_dsc")]
        public string SpdbTranTpDsc { get; set; }
    }
}
