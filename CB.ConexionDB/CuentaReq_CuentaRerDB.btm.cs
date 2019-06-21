namespace CB.ConexionDB {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CB.ConexionDB.CuentaReq", typeof(global::CB.ConexionDB.CuentaReq))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CB.ConexionDB.InserttbCuentaService_v1+CuentasReq", typeof(global::CB.ConexionDB.InserttbCuentaService_v1.CuentasReq))]
    public sealed class CuentaReq_CuentaRerDB : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://CB.ConexionDB.CuentaReq"" xmlns:ns0=""htttp://EsquemaCuentas/v1"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:CuentaReq"" />
  </xsl:template>
  <xsl:template match=""/s0:CuentaReq"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(string(Nombres/text()) , &quot; &quot; , string(Apellidos/text()))"" />
    <ns0:CuentasReq>
      <ns0:sync>
        <ns0:after>
          <ns0:tbCuenta>
            <xsl:attribute name=""NombreCliente"">
              <xsl:value-of select=""$var:v1"" />
            </xsl:attribute>
            <xsl:attribute name=""TipoCuenta"">
              <xsl:value-of select=""TipoCuenta/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""NumeroCuenta"">
              <xsl:value-of select=""NumeroCuenta/text()"" />
            </xsl:attribute>
          </ns0:tbCuenta>
        </ns0:after>
      </ns0:sync>
    </ns0:CuentasReq>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"CB.ConexionDB.CuentaReq";
        
        private const global::CB.ConexionDB.CuentaReq _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"CB.ConexionDB.InserttbCuentaService_v1+CuentasReq";
        
        private const global::CB.ConexionDB.InserttbCuentaService_v1.CuentasReq _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"CB.ConexionDB.CuentaReq";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"CB.ConexionDB.InserttbCuentaService_v1+CuentasReq";
                return _TrgSchemas;
            }
        }
    }
}
