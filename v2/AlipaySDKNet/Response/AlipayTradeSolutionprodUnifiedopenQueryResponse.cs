using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeSolutionprodUnifiedopenQueryResponse.
    /// </summary>
    public class AlipayTradeSolutionprodUnifiedopenQueryResponse : AopResponse
    {
        /// <summary>
        /// 开通绑定的支付宝登录号（脱敏）
        /// </summary>
        [XmlElement("binding_logon_id")]
        public string BindingLogonId { get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 开通项结果列表
        /// </summary>
        [XmlArray("open_item_result_list")]
        [XmlArrayItem("uni_open_res_item")]
        public List<UniOpenResItem> OpenItemResultList { get; set; }

        /// <summary>
        /// 外部请求流水号，调用alipay.trade.solutionprod.unifiedopen.apply接口时由商户传入
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 聚合开通申请单号，聚合开通申请后由支付宝生成
        /// </summary>
        [XmlElement("uniopen_order_id")]
        public string UniopenOrderId { get; set; }

        /// <summary>
        /// INIT:已申请用户还未确认开通 、ROCESSING：开通中 、SUCCESS:所有开通项都成功 、FAIL:整体失败且需重新换单进行个人卖家进件&聚合开通，需要查看开通项结果明细，存在部分成功部分失败。若钱包成功，下一次请求中无需再开通，若需要设置默认结算账号为钱包，则将钱包id带入到下一次聚合开通请求中、RETYR:整体失败可原单重试（包括部分失败），根据错误原因进行排查，解决后可用原单进行重试
        /// </summary>
        [XmlElement("uniopen_status")]
        public string UniopenStatus { get; set; }
    }
}
