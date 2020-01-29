<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns="http://www.w3.org/TR/xhtml1/strict">
  <xsl:template match="/">
    <html>
      <head>
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>Реестр сертификатов</title>
        <style type="text/css">
          table.registry
          {
          border-style: solid;
          border-width: 1;
          border-color: black;
          width: 100%;
          text-align: center;
          border-collapse: collapse;
          margin-top: 20px;
          margin-bottom: 20px;
          }
          th
          {
          text-align: center;
          border-style: solid;
          border-width: 1;
          border-color: black;
          }
          td.cell
          {
          text-align: center;
          border-style: solid;
          border-width: 1;
          border-color: black;
          }
          .font5
          {
          font-size: large
          }
        </style>
      </head>
      <body>
        <table>
          <tr>
            <td class="font5">Данное приложение является подтверждением факта сертификации.</td>
          </tr>
          <tr>
            <td class="font5">Основание:  Постановление Правительства Российской Федерации от 19 января 1998 г. № 55, в редакции постановлений от 20 октября 1998 г. № 122, от 02 октября 1999 г. № 1104</td>
          </tr>
        </table>
        <h2 align="center">Реестр сертификатов</h2>
        <table class="registry">
          <tr class="row">
            <th>Название</th>
            <th>Номер</th>
            <th>Дата выдачи</th>
            <th>Дата завершения</th>
            <th>Орган, выдавший сертификат</th>
          </tr>
          <xsl:for-each select="registry/certificates/certificate">
            <tr class="row">
              <td class="cell">
                <xsl:value-of select="name"/>
              </td>
              <td class="cell">
                <xsl:value-of select="number"/>
              </td>
              <td class="cell">
                <xsl:value-of select="begin_date"/>
              </td>
              <td class="cell">
                <xsl:value-of select="end_date"/>
              </td>
              <td class="cell">
                <xsl:value-of select="organization"/>
              </td>
            </tr>
          </xsl:for-each>
        </table>
        <table class="font5">
          <tr>
            <td>В соответствии с порядком проведения сертификации продукции в РФ, утвержденном постановлением Госстандарта от 21.09.1994 №15 и разъяснительным письмом (от 27.04.2006) Федеральной службы по ветеринарному и фитосанитарному надзору МСХ РФ, продукция, изготовленная в течение срока действия   сертификата соответствия, может быть использована по назначению до окончания гарантийного срока её годности.</td>
          </tr>
          <tr>
            <td>
              Оригиналы сертификатов соответствия или их заверенные копии находятся по адресу:
              <strong>
                <xsl:value-of select="registry/address"/>
              </strong>
            </td>
          </tr>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>