<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:xs="http://www.w3.org/2001/XMLSchema"
    exclude-result-prefixes="xs"
    version="2.0">
    <xsl:template match="/">
        <issues>
            <xsl:apply-templates/>
        </issues>
    </xsl:template>
    <xsl:template match="errorType">
        <issue display="yes" weight="1">
            <xsl:attribute name="type">
                <xsl:value-of select="./@id"/>
            </xsl:attribute>
            <xsl:attribute name="level">
                <xsl:value-of select="./@level"/>
            </xsl:attribute>
            <xsl:apply-templates select="errorType"/>
        </issue>
    </xsl:template>
</xsl:stylesheet>