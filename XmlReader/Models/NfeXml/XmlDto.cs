using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlReader.Models.NfeXml
{
    public class XmlDto
    {
    }

    public static class NfeConsts
    {
        public const string NS = "http://www.portalfiscal.inf.br/nfe";
    }

    [XmlRoot(ElementName = "ide", Namespace = NfeConsts.NS)]
    public class Ide
    {
        [XmlElement(ElementName = "cUF")]
        public int CUF { get; set; }

        [XmlElement(ElementName = "cNF")]
        public int CNF { get; set; }

        [XmlElement(ElementName = "natOp")]
        public string NatOp { get; set; }

        [XmlElement(ElementName = "mod")]
        public int Mod { get; set; }

        [XmlElement(ElementName = "serie")]
        public int Serie { get; set; }

        [XmlElement(ElementName = "nNF")]
        public int NNF { get; set; }

        [XmlElement(ElementName = "dhEmi")]
        public DateTime DhEmi { get; set; }

        [XmlElement(ElementName = "tpNF")]
        public int TpNF { get; set; }

        [XmlElement(ElementName = "idDest")]
        public int IdDest { get; set; }

        [XmlElement(ElementName = "cMunFG")]
        public int CMunFG { get; set; }

        [XmlElement(ElementName = "tpImp")]
        public int TpImp { get; set; }

        [XmlElement(ElementName = "tpEmis")]
        public int TpEmis { get; set; }

        [XmlElement(ElementName = "cDV")]
        public int CDV { get; set; }

        [XmlElement(ElementName = "tpAmb")]
        public int TpAmb { get; set; }

        [XmlElement(ElementName = "finNFe")]
        public int FinNFe { get; set; }

        [XmlElement(ElementName = "indFinal")]
        public int IndFinal { get; set; }

        [XmlElement(ElementName = "indPres")]
        public int IndPres { get; set; }

        [XmlElement(ElementName = "procEmi")]
        public int ProcEmi { get; set; }

        [XmlElement(ElementName = "verProc")]
        public string VerProc { get; set; }
    }

    [XmlRoot(ElementName = "enderEmit", Namespace = NfeConsts.NS)]
    public class EnderEmit
    {
        [XmlElement(ElementName = "xLgr")]
        public string XLgr { get; set; }

        [XmlElement(ElementName = "nro")]
        public string Nro { get; set; }

        [XmlElement(ElementName = "xCpl")]
        public string XCpl { get; set; }

        [XmlElement(ElementName = "xBairro")]
        public string XBairro { get; set; }

        [XmlElement(ElementName = "cMun")]
        public int CMun { get; set; }

        [XmlElement(ElementName = "xMun")]
        public string XMun { get; set; }

        [XmlElement(ElementName = "UF")]
        public string UF { get; set; }

        [XmlElement(ElementName = "CEP")]
        public string CEP { get; set; }

        [XmlElement(ElementName = "fone")]
        public string Fone { get; set; }
    }

    [XmlRoot(ElementName = "emit", Namespace = NfeConsts.NS)]
    public class Emit
    {
        [XmlElement(ElementName = "CNPJ")]
        public string CNPJ { get; set; }

        [XmlElement(ElementName = "xNome")]
        public string XNome { get; set; }

        [XmlElement(ElementName = "xFant")]
        public string XFant { get; set; }

        [XmlElement(ElementName = "enderEmit")]
        public EnderEmit EnderEmit { get; set; }

        [XmlElement(ElementName = "IE")]
        public string IE { get; set; }

        [XmlElement(ElementName = "CRT")]
        public int CRT { get; set; }
    }

    [XmlRoot(ElementName = "enderDest", Namespace = NfeConsts.NS)]
    public class EnderDest
    {
        [XmlElement(ElementName = "xLgr")]
        public string XLgr { get; set; }

        [XmlElement(ElementName = "nro")]
        public string Nro { get; set; }

        [XmlElement(ElementName = "xBairro")]
        public string XBairro { get; set; }

        [XmlElement(ElementName = "cMun")]
        public int CMun { get; set; }

        [XmlElement(ElementName = "xMun")]
        public string XMun { get; set; }

        [XmlElement(ElementName = "UF")]
        public string UF { get; set; }

        [XmlElement(ElementName = "CEP")]
        public string CEP { get; set; }

        [XmlElement(ElementName = "cPais")]
        public int CPais { get; set; }

        [XmlElement(ElementName = "fone")]
        public string Fone { get; set; }
    }

    [XmlRoot(ElementName = "dest", Namespace = NfeConsts.NS)]
    public class Dest
    {
        [XmlElement(ElementName = "CNPJ")]
        public string CNPJ { get; set; }

        [XmlElement(ElementName = "xNome")]
        public string XNome { get; set; }

        [XmlElement(ElementName = "enderDest")]
        public EnderDest EnderDest { get; set; }

        [XmlElement(ElementName = "indIEDest")]
        public int IndIEDest { get; set; }

        [XmlElement(ElementName = "IE")]
        public string IE { get; set; }
    }

    [XmlRoot(ElementName = "comb", Namespace = NfeConsts.NS)]
    public class Comb
    {
        [XmlElement(ElementName = "cProdANP")]
        public int CProdANP { get; set; }

        [XmlElement(ElementName = "descANP")]
        public string DescANP { get; set; }

        [XmlElement(ElementName = "UFCons")]
        public string UFCons { get; set; }
    }

    [XmlRoot(ElementName = "prod", Namespace = NfeConsts.NS)]
    public class Prod
    {
        [XmlElement(ElementName = "cProd")]
        public string CProd { get; set; }

        [XmlElement(ElementName = "cEAN")]
        public string CEAN { get; set; }

        [XmlElement(ElementName = "xProd")]
        public string XProd { get; set; }

        [XmlElement(ElementName = "NCM")]
        public int NCM { get; set; }

        [XmlElement(ElementName = "CEST")]
        public int CEST { get; set; }

        [XmlElement(ElementName = "CFOP")]
        public int CFOP { get; set; }

        [XmlElement(ElementName = "uCom")]
        public string UCom { get; set; }

        [XmlElement(ElementName = "qCom")]
        public double QCom { get; set; }

        [XmlElement(ElementName = "vUnCom")]
        public double VUnCom { get; set; }

        [XmlElement(ElementName = "vProd")]
        public double VProd { get; set; }

        [XmlElement(ElementName = "cEANTrib")]
        public string CEANTrib { get; set; }

        [XmlElement(ElementName = "uTrib")]
        public string UTrib { get; set; }

        [XmlElement(ElementName = "qTrib")]
        public double QTrib { get; set; }

        [XmlElement(ElementName = "vUnTrib")]
        public double VUnTrib { get; set; }

        [XmlElement(ElementName = "indTot")]
        public int IndTot { get; set; }

        [XmlElement(ElementName = "xPed")]
        public string XPed { get; set; }

        [XmlElement(ElementName = "nFCI")]
        public string NFCI { get; set; }

        [XmlElement(ElementName = "comb")]
        public Comb Comb { get; set; }
    }

    [XmlRoot(ElementName = "ICMS00", Namespace = NfeConsts.NS)]
    public class ICMS00
    {
        [XmlElement(ElementName = "orig")]
        public int Orig { get; set; }

        [XmlElement(ElementName = "CST")]
        public int CST { get; set; }

        [XmlElement(ElementName = "modBC")]
        public int ModBC { get; set; }

        [XmlElement(ElementName = "vBC")]
        public double VBC { get; set; }

        [XmlElement(ElementName = "pICMS")]
        public double PICMS { get; set; }

        [XmlElement(ElementName = "vICMS")]
        public double VICMS { get; set; }
    }

    [XmlRoot(ElementName = "ICMS", Namespace = NfeConsts.NS)]
    public class ICMS
    {
        [XmlElement(ElementName = "ICMS00")]
        public ICMS00 ICMS00 { get; set; }
    }

    [XmlRoot(ElementName = "IPITrib", Namespace = NfeConsts.NS)]
    public class IPITrib
    {
        [XmlElement(ElementName = "CST")]
        public int CST { get; set; }

        [XmlElement(ElementName = "vBC")]
        public double VBC { get; set; }

        [XmlElement(ElementName = "pIPI")]
        public double PIPI { get; set; }

        [XmlElement(ElementName = "vIPI")]
        public double VIPI { get; set; }
    }

    [XmlRoot(ElementName = "IPI", Namespace = NfeConsts.NS)]
    public class IPI
    {
        [XmlElement(ElementName = "cEnq")]
        public int CEnq { get; set; }

        [XmlElement(ElementName = "IPITrib")]
        public IPITrib IPITrib { get; set; }
    }

    [XmlRoot(ElementName = "PISAliq", Namespace = NfeConsts.NS)]
    public class PISAliq
    {
        [XmlElement(ElementName = "CST")]
        public int CST { get; set; }

        [XmlElement(ElementName = "vBC")]
        public double VBC { get; set; }

        [XmlElement(ElementName = "pPIS")]
        public double PPIS { get; set; }

        [XmlElement(ElementName = "vPIS")]
        public double VPIS { get; set; }
    }

    [XmlRoot(ElementName = "PIS", Namespace = NfeConsts.NS)]
    public class PIS
    {
        [XmlElement(ElementName = "PISAliq")]
        public PISAliq PISAliq { get; set; }
    }

    [XmlRoot(ElementName = "COFINSAliq", Namespace = NfeConsts.NS)]
    public class COFINSAliq
    {
        [XmlElement(ElementName = "CST")]
        public int CST { get; set; }

        [XmlElement(ElementName = "vBC")]
        public double VBC { get; set; }

        [XmlElement(ElementName = "pCOFINS")]
        public double PCOFINS { get; set; }

        [XmlElement(ElementName = "vCOFINS")]
        public double VCOFINS { get; set; }
    }

    [XmlRoot(ElementName = "COFINS", Namespace = NfeConsts.NS)]
    public class COFINS
    {
        [XmlElement(ElementName = "COFINSAliq")]
        public COFINSAliq COFINSAliq { get; set; }
    }

    [XmlRoot(ElementName = "imposto", Namespace = NfeConsts.NS)]
    public class Imposto
    {
        [XmlElement(ElementName = "ICMS")]
        public ICMS ICMS { get; set; }

        [XmlElement(ElementName = "IPI")]
        public IPI IPI { get; set; }

        [XmlElement(ElementName = "PIS")]
        public PIS PIS { get; set; }

        [XmlElement(ElementName = "COFINS")]
        public COFINS COFINS { get; set; }
    }

    [XmlRoot(ElementName = "det", Namespace = NfeConsts.NS)]
    public class Det
    {
        [XmlElement(ElementName = "prod")]
        public Prod Prod { get; set; }

        [XmlElement(ElementName = "imposto")]
        public Imposto Imposto { get; set; }

        [XmlElement(ElementName = "infAdProd")]
        public string InfAdProd { get; set; }

        [XmlAttribute(AttributeName = "nItem")]
        public int NItem { get; set; }
    }

    [XmlRoot(ElementName = "ICMSTot", Namespace = NfeConsts.NS)]
    public class ICMSTot
    {
        [XmlElement(ElementName = "vBC")]
        public double VBC { get; set; }

        [XmlElement(ElementName = "vICMS")]
        public double VICMS { get; set; }

        [XmlElement(ElementName = "vICMSDeson")]
        public double VICMSDeson { get; set; }

        [XmlElement(ElementName = "vFCP")]
        public double VFCP { get; set; }

        [XmlElement(ElementName = "vBCST")]
        public double VBCST { get; set; }

        [XmlElement(ElementName = "vST")]
        public double VST { get; set; }

        [XmlElement(ElementName = "vFCPST")]
        public double VFCPST { get; set; }

        [XmlElement(ElementName = "vFCPSTRet")]
        public double VFCPSTRet { get; set; }

        [XmlElement(ElementName = "vProd")]
        public double VProd { get; set; }

        [XmlElement(ElementName = "vFrete")]
        public double VFrete { get; set; }

        [XmlElement(ElementName = "vSeg")]
        public double VSeg { get; set; }

        [XmlElement(ElementName = "vDesc")]
        public double VDesc { get; set; }

        [XmlElement(ElementName = "vII")]
        public double VII { get; set; }

        [XmlElement(ElementName = "vIPI")]
        public double VIPI { get; set; }

        [XmlElement(ElementName = "vIPIDevol")]
        public double VIPIDevol { get; set; }

        [XmlElement(ElementName = "vPIS")]
        public double VPIS { get; set; }

        [XmlElement(ElementName = "vCOFINS")]
        public double VCOFINS { get; set; }

        [XmlElement(ElementName = "vOutro")]
        public double VOutro { get; set; }

        [XmlElement(ElementName = "vNF")]
        public double VNF { get; set; }
    }

    [XmlRoot(ElementName = "total", Namespace = NfeConsts.NS)]
    public class Total
    {
        [XmlElement(ElementName = "ICMSTot")]
        public ICMSTot ICMSTot { get; set; }
    }

    [XmlRoot(ElementName = "transporta", Namespace = NfeConsts.NS)]
    public class Transporta
    {
        [XmlElement(ElementName = "CNPJ")]
        public string CNPJ { get; set; }

        [XmlElement(ElementName = "xNome")]
        public string XNome { get; set; }

        [XmlElement(ElementName = "IE")]
        public string IE { get; set; }

        [XmlElement(ElementName = "xEnder")]
        public string XEnder { get; set; }

        [XmlElement(ElementName = "xMun")]
        public string XMun { get; set; }

        [XmlElement(ElementName = "UF")]
        public string UF { get; set; }
    }

    [XmlRoot(ElementName = "vol", Namespace = NfeConsts.NS)]
    public class Vol
    {
        [XmlElement(ElementName = "qVol")]
        public int QVol { get; set; }

        [XmlElement(ElementName = "esp")]
        public string Esp { get; set; }

        [XmlElement(ElementName = "nVol")]
        public string NVol { get; set; }

        [XmlElement(ElementName = "pesoL")]
        public double PesoL { get; set; }

        [XmlElement(ElementName = "pesoB")]
        public double PesoB { get; set; }
    }

    [XmlRoot(ElementName = "transp", Namespace = NfeConsts.NS)]
    public class Transp
    {
        [XmlElement(ElementName = "modFrete")]
        public int ModFrete { get; set; }

        [XmlElement(ElementName = "transporta")]
        public Transporta Transporta { get; set; }

        [XmlElement(ElementName = "vol")]
        public Vol Vol { get; set; }
    }

    [XmlRoot(ElementName = "fat", Namespace = NfeConsts.NS)]
    public class Fat
    {
        [XmlElement(ElementName = "nFat")]
        public string NFat { get; set; }

        [XmlElement(ElementName = "vOrig")]
        public double VOrig { get; set; }

        [XmlElement(ElementName = "vDesc")]
        public double VDesc { get; set; }

        [XmlElement(ElementName = "vLiq")]
        public double VLiq { get; set; }
    }

    [XmlRoot(ElementName = "dup", Namespace = NfeConsts.NS)]
    public class Dup
    {
        [XmlElement(ElementName = "nDup")]
        public string NDup { get; set; }

        [XmlElement(ElementName = "dVenc")]
        public DateTime DVenc { get; set; }

        [XmlElement(ElementName = "vDup")]
        public double VDup { get; set; }
    }

    [XmlRoot(ElementName = "cobr", Namespace = NfeConsts.NS)]
    public class Cobr
    {
        [XmlElement(ElementName = "fat")]
        public Fat Fat { get; set; }

        [XmlElement(ElementName = "dup")]
        public Dup Dup { get; set; }
    }

    [XmlRoot(ElementName = "detPag", Namespace = NfeConsts.NS)]
    public class DetPag
    {
        [XmlElement(ElementName = "tPag")]
        public int TPag { get; set; }

        [XmlElement(ElementName = "vPag")]
        public double VPag { get; set; }
    }

    [XmlRoot(ElementName = "pag", Namespace = NfeConsts.NS)]
    public class Pag
    {
        [XmlElement(ElementName = "detPag")]
        public DetPag DetPag { get; set; }
    }

    [XmlRoot(ElementName = "infAdic", Namespace = NfeConsts.NS)]
    public class InfAdic
    {
        [XmlElement(ElementName = "infCpl")]
        public string InfCpl { get; set; }
    }

    [XmlRoot(ElementName = "infRespTec", Namespace = NfeConsts.NS)]
    public class InfRespTec
    {
        [XmlElement(ElementName = "CNPJ")]
        public string CNPJ { get; set; }

        [XmlElement(ElementName = "xContato")]
        public string XContato { get; set; }

        [XmlElement(ElementName = "email")]
        public string Email { get; set; }

        [XmlElement(ElementName = "fone")]
        public string Fone { get; set; }

        [XmlElement(ElementName = "idCSRT")]
        public int IdCSRT { get; set; }

        [XmlElement(ElementName = "hashCSRT")]
        public string HashCSRT { get; set; }
    }

    [XmlRoot(ElementName = "infNFe", Namespace = NfeConsts.NS)]
    public class InfNFe
    {
        [XmlElement(ElementName = "ide")]
        public Ide Ide { get; set; }

        [XmlElement(ElementName = "emit")]
        public Emit Emit { get; set; }

        [XmlElement(ElementName = "dest")]
        public Dest Dest { get; set; }

        [XmlElement(ElementName = "det")]
        public List<Det> Det { get; set; }

        [XmlElement(ElementName = "total")]
        public Total Total { get; set; }

        [XmlElement(ElementName = "transp")]
        public Transp Transp { get; set; }

        [XmlElement(ElementName = "cobr")]
        public Cobr Cobr { get; set; }

        [XmlElement(ElementName = "pag")]
        public Pag Pag { get; set; }

        [XmlElement(ElementName = "infAdic")]
        public InfAdic InfAdic { get; set; }

        [XmlElement(ElementName = "infRespTec")]
        public InfRespTec InfRespTec { get; set; }

        [XmlAttribute(AttributeName = "Id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "versao")]
        public double Versao { get; set; }
    }

    [XmlRoot(ElementName = "CanonicalizationMethod")]
    public class CanonicalizationMethod
    {
        [XmlAttribute(AttributeName = "Algorithm")]
        public string Algorithm { get; set; }
    }

    [XmlRoot(ElementName = "SignatureMethod")]
    public class SignatureMethod
    {
        [XmlAttribute(AttributeName = "Algorithm")]
        public string Algorithm { get; set; }
    }

    [XmlRoot(ElementName = "Transform")]
    public class Transform
    {
        [XmlAttribute(AttributeName = "Algorithm")]
        public string Algorithm { get; set; }
    }

    [XmlRoot(ElementName = "Transforms")]
    public class Transforms
    {
        [XmlElement(ElementName = "Transform")]
        public List<Transform> Transform { get; set; }
    }

    [XmlRoot(ElementName = "DigestMethod")]
    public class DigestMethod
    {
        [XmlAttribute(AttributeName = "Algorithm")]
        public string Algorithm { get; set; }
    }

    [XmlRoot(ElementName = "Reference")]
    public class Reference
    {
        [XmlElement(ElementName = "Transforms")]
        public Transforms Transforms { get; set; }

        [XmlElement(ElementName = "DigestMethod")]
        public DigestMethod DigestMethod { get; set; }

        [XmlElement(ElementName = "DigestValue")]
        public string DigestValue { get; set; }

        [XmlAttribute(AttributeName = "URI")]
        public string URI { get; set; }
    }

    [XmlRoot(ElementName = "SignedInfo")]
    public class SignedInfo
    {
        [XmlElement(ElementName = "CanonicalizationMethod")]
        public CanonicalizationMethod CanonicalizationMethod { get; set; }

        [XmlElement(ElementName = "SignatureMethod")]
        public SignatureMethod SignatureMethod { get; set; }

        [XmlElement(ElementName = "Reference")]
        public Reference Reference { get; set; }
    }

    [XmlRoot(ElementName = "X509Data")]
    public class X509Data
    {
        [XmlElement(ElementName = "X509Certificate")]
        public string X509Certificate { get; set; }
    }

    [XmlRoot(ElementName = "KeyInfo")]
    public class KeyInfo
    {
        [XmlElement(ElementName = "X509Data")]
        public X509Data X509Data { get; set; }
    }

    [XmlRoot(ElementName = "Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class Signature
    {
        [XmlElement(ElementName = "SignedInfo")]
        public SignedInfo SignedInfo { get; set; }

        [XmlElement(ElementName = "SignatureValue")]
        public string SignatureValue { get; set; }

        [XmlElement(ElementName = "KeyInfo")]
        public KeyInfo KeyInfo { get; set; }
    }

    [XmlRoot(ElementName = "NFe", Namespace = NfeConsts.NS)]
    public class NFe
    {
        [XmlElement(ElementName = "infNFe")]
        public InfNFe InfNFe { get; set; }

        [XmlElement(ElementName = "Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public Signature Signature { get; set; }
    }

    [XmlRoot(ElementName = "infProt", Namespace = NfeConsts.NS)]
    public class InfProt
    {
        [XmlElement(ElementName = "tpAmb")]
        public int TpAmb { get; set; }

        [XmlElement(ElementName = "verAplic")]
        public string VerAplic { get; set; }

        [XmlElement(ElementName = "chNFe")]
        public string ChNFe { get; set; }

        [XmlElement(ElementName = "dhRecbto")]
        public DateTime DhRecbto { get; set; }

        [XmlElement(ElementName = "nProt")]
        public string NProt { get; set; }

        [XmlElement(ElementName = "digVal")]
        public string DigVal { get; set; }

        [XmlElement(ElementName = "cStat")]
        public int CStat { get; set; }

        [XmlElement(ElementName = "xMotivo")]
        public string XMotivo { get; set; }

        [XmlAttribute(AttributeName = "Id")]
        public string Id { get; set; }
    }

    [XmlRoot(ElementName = "protNFe", Namespace = NfeConsts.NS)]
    public class ProtNFe
    {
        [XmlElement(ElementName = "infProt")]
        public InfProt InfProt { get; set; }

        [XmlAttribute(AttributeName = "versao")]
        public double Versao { get; set; }
    }

    [XmlRoot(ElementName = "nfeProc", Namespace = NfeConsts.NS)]
    public class NfeProc
    {
        [XmlElement(ElementName = "NFe")]
        public NFe NFe { get; set; }

        [XmlElement(ElementName = "protNFe")]
        public ProtNFe ProtNFe { get; set; }

        [XmlAttribute(AttributeName = "versao")]
        public double Versao { get; set; }
    }
}
