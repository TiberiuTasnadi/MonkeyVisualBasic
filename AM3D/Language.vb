﻿Public Class Language
    Public Shared Function setLang()
        Dim opcio1 As String
        Dim opcio2 As String
        Dim opcio3 As String
        Dim opcio4 As String
        If globals.lang = "cat" Then
            MenuPrincipal.user.Items.Clear()
            opcio1 = My.Resources.cat.opcioPerfil
            opcio2 = My.Resources.cat.opcioCambiarIdioma
            opcio3 = My.Resources.cat.opcioSortir
            opcio4 = My.Resources.cat.opcioGenerarEstadistiques
            MenuPrincipal.LBControl.Text = My.Resources.cat.LBControl
            MenuPrincipal.LBGestio.Text = My.Resources.cat.LBGestio
            MenuPrincipal.LBImpressions.Text = My.Resources.cat.LBImpressions
            MenuPrincipal.LBImpressores.Text = My.Resources.cat.LBImpressores
            MenuPrincipal.LBInici.Text = My.Resources.cat.LInici
            Login.Lidioma.Text = My.Resources.cat.Lidioma
            Login.LUsuari.Text = My.Resources.cat.LUsuari
            Login.LContrasenya.Text = My.Resources.cat.LContrasenya
            Login.CBRecordar.Text = My.Resources.cat.CBRecordar
            Login.ButtonLogin.Text = My.Resources.cat.ButtonLogin
            Login.LabelErrorLogin.Text = My.Resources.cat.LabelErrorLogin

            MenuPrincipal.LBUsuaris.Text = My.Resources.cat.LUsuaris
            MenuPrincipal.LBBobines.Text = My.Resources.cat.LBobines
            MenuPrincipal.LBModelsCar.Text = My.Resources.cat.LModels
            MenuPrincipal.LBGCode.Text = My.Resources.cat.LGcode

            FUsuaris.BTAfegir.Text = My.Resources.cat.BTAfegir
            FUsuaris.BTModificarEliminar.Text = My.Resources.cat.BTModificarEliminar

            FBobines.LBobina.Text = My.Resources.cat.LBobina
            FBobines.LColor.Text = My.Resources.cat.LColor
            FBobines.LMarca.Text = My.Resources.cat.LMarca
            FBobines.LMaterial.Text = My.Resources.cat.LMaterial
            FBobines.BTBobinaAfegir.Text = My.Resources.cat.BTAfegir
            FBobines.BTBobinaModif.Text = My.Resources.cat.BTModificarBobina
            FBobines.BTColorAfegir.Text = My.Resources.cat.BTAfegir
            FBobines.BTColorModif.Text = My.Resources.cat.BTModificarColor
            FBobines.BTMarcaAfegir.Text = My.Resources.cat.BTAfegir
            FBobines.BTMarcaModif.Text = My.Resources.cat.BTModificarMarca
            FBobines.BTMaterialAfegir.Text = My.Resources.cat.BTAfegir
            FBobines.BTMaterialModif.Text = My.Resources.cat.BTModificarMaterial
            FCambIdiom.LSelecionarIdioma.Text = My.Resources.cat.LSelecionarIdioma
            FGcode.BTAfegir.Text = My.Resources.cat.BTAfegir
            FGcode.BTModificarEliminar.Text = My.Resources.cat.BTModificarEliminar
            FImpressions.BTCancelar.Text = My.Resources.cat.BTCancelar
            FImpressions.BTImpressionsPeçaRetirada.Text = My.Resources.cat.BTImpressionsPeçaRetirada
            FImpressions.BTImprimirG.Text = My.Resources.cat.BTImprimirG
            FImpressions.BResfrescar.Text = My.Resources.cat.BResfrescar
            FImpressores.BTConnectar.Text = My.Resources.cat.BTConnectar
            FImpressores.BTLlista.Text = My.Resources.cat.BTLlista
            FInici.LBenvingut.Text = My.Resources.cat.LBenvingut
            FInici.LApliFun.Text = My.Resources.cat.LApliFun
            FInici.LControl.Text = My.Resources.cat.LControl
            FInici.LGestio.Text = My.Resources.cat.LGestio
            FInici.LImpressores.Text = My.Resources.cat.LBImpressores
            FInici.LImpressions.Text = My.Resources.cat.LBImpressions
            FInici.LUsuaris.Text = My.Resources.cat.LUsuaris
            FInici.LModels.Text = My.Resources.cat.LModels
            FInici.LGcode.Text = My.Resources.cat.LGcode
            FInici.LBobines.Text = My.Resources.cat.LBobines
            FModels.LMarca.Text = My.Resources.cat.LMarca
            FModels.LModel.Text = My.Resources.cat.LModel
            FModels.BTMarcaAfegir.Text = My.Resources.cat.BTAfegir
            FModels.BTMarcaModificar.Text = My.Resources.cat.BTModificarMarca
            FModels.BTModelAfegir.Text = My.Resources.cat.BTAfegir
            FModels.BTModelModificar.Text = My.Resources.cat.BTModificarModel
            FPerfil.LDades.Text = My.Resources.cat.LDades
            FPerfil.CBModificar.Text = My.Resources.cat.CBModificar
            FPerfil.LDni.Text = My.Resources.cat.LDni
            FPerfil.LNom.Text = My.Resources.cat.LNom
            FPerfil.LCognom.Text = My.Resources.cat.LCognom
            FPerfil.LEmail.Text = My.Resources.cat.LEmail
            FPerfil.LCanvContr.Text = My.Resources.cat.LCanvContr
            FPerfil.LActual.Text = My.Resources.cat.LActual
            FPerfil.LNova.Text = My.Resources.cat.LNova
            FPerfil.LRContra.Text = My.Resources.cat.LRContra
            FPerfil.BTCanviarContra.Text = My.Resources.cat.CanviarContrasenya
            FPerfil.BTActualitzar.Text = My.Resources.cat.BTActualitzar
            PanelBobinesBobinaAfegir.LDiametre.Text = My.Resources.cat.LDiametre
            PanelBobinesBobinaAfegir.BTAfegir.Text = My.Resources.cat.BTAfegir
            PanelBobinesBobinaAfegir.BTBorrar.Text = My.Resources.cat.BTBorrar
            PanelBobinesBobinaAfegir.LMaterial.Text = My.Resources.cat.LMaterial
            PanelBobinesBobinaAfegir.LMarca.Text = My.Resources.cat.LMarca
            PanelBobinesBobinaAfegir.LColor.Text = My.Resources.cat.LColor
            PanelBobinesBobinaModificarEliminar.BTModificarBobina.Text = My.Resources.cat.BTModificarBobina
            PanelBobinesBobinaModificarEliminar.BTEliminarBobina.Text = My.Resources.cat.BTEliminarBobina
            PanelBobinesBobinaModificarEliminar.BResfrescar.Text = My.Resources.cat.BResfrescar
            PanelBobinesColorAfegir.LColor.Text = My.Resources.cat.LColor
            PanelBobinesColorAfegir.LHex.Text = My.Resources.cat.LHex
            PanelBobinesColorAfegir.BTAfegir.Text = My.Resources.cat.BTAfegir
            PanelBobinesColorAfegir.BTBorrar.Text = My.Resources.cat.BTBorrar
            PanelBobinesColorModificarEliminar.BTModificarColor.Text = My.Resources.cat.BTModificarColor
            PanelBobinesColorModificarEliminar.BTEliminarColor.Text = My.Resources.cat.BTEliminarColor
            PanelBobinesColorModificarEliminar.BResfrescar.Text = My.Resources.cat.BResfrescar
            PanelBobinesMarcaAfegir.LMarcaProductora.Text = My.Resources.cat.LMarcaProductora
            PanelBobinesMarcaAfegir.BTAfegir.Text = My.Resources.cat.BTAfegir
            PanelBobinesMarcaAfegir.BTBorrar.Text = My.Resources.cat.BTBorrar
            PanelBobinesMarcaModificarEliminar.BTModificarMarca.Text = My.Resources.cat.BTModificarMarca
            PanelBobinesMarcaModificarEliminar.BTEliminarMarca.Text = My.Resources.cat.BTEliminarMarca
            PanelBobinesMarcaModificarEliminar.BResfrescar.Text = My.Resources.cat.BResfrescar
            PanelBobinesMaterialAfegir.LMaterial.Text = My.Resources.cat.LMaterial
            PanelBobinesMaterialAfegir.LTecnic.Text = My.Resources.cat.LTecnic
            PanelBobinesMaterialAfegir.BTAfegir.Text = My.Resources.cat.BTAfegir
            PanelBobinesMaterialAfegir.BTBorrar.Text = My.Resources.cat.BTBorrar
            PanelBobinesMaterialModificarEliminar.BTEliminarMaterial.Text = My.Resources.cat.BTEliminarMaterial
            PanelBobinesMaterialModificarEliminar.BTModificarMaterial.Text = My.Resources.cat.BTModificarMaterial
            PanelBobinesMaterialModificarEliminar.BResfrescar.Text = My.Resources.cat.BResfrescar
            PanelConnectarNovaImpressora.LModel.Text = My.Resources.cat.LModel
            PanelConnectarNovaImpressora.LMarca.Text = My.Resources.cat.LMarca
            PanelConnectarNovaImpressora.LNom.Text = My.Resources.cat.LNom
            PanelConnectarNovaImpressora.LBobina.Text = My.Resources.cat.LBobina
            PanelConnectarNovaImpressora.BTImpressoraGuardar.Text = My.Resources.cat.BTGuardar
            PanelConnectarNovaImpressora.BTImpressoraBorrar.Text = My.Resources.cat.BTBorrar
            PanelGcodeAfegir.LNomGcode.Text = My.Resources.cat.LNomGcode
            PanelGcodeAfegir.LMaterialsSup.Text = My.Resources.cat.LMaterialsSup
            PanelGcodeAfegir.LRuta.Text = My.Resources.cat.LRutaFich
            PanelGcodeAfegir.BTAfegir.Text = My.Resources.cat.BTAfegir
            PanelGcodeAfegir.BTBorrar.Text = My.Resources.cat.BTBorrar
            PanelGcodeModificarEliminar.BTModificarGcode.Text = My.Resources.cat.BTModificarGcode
            PanelGcodeModificarEliminar.BTEliminarGcode.Text = My.Resources.cat.BTEliminarGcode
            PanelGcodeModificarEliminar.BResfrescar.Text = My.Resources.cat.BResfrescar
            PanelLlistaImpressores.BTCambiarBobina.Text = My.Resources.cat.BTCambiarBobina
            PanelLlistaImpressores.BTModificarImpressora.Text = My.Resources.cat.BTModificarImpressora
            PanelLlistaImpressores.BTEliminarImpressora.Text = My.Resources.cat.BTEliminarImpressora
            PanelLlistaImpressores.BResfrescar.Text = My.Resources.cat.BResfrescar
            PanelMarcaAfegir.LMarca.Text = My.Resources.cat.LMarca
            PanelMarcaAfegir.BTAfegir.Text = My.Resources.cat.BTAfegir
            PanelMarcaAfegir.BTBorrar.Text = My.Resources.cat.BTBorrar
            PanelMarcaModificarEliminar.BTModificarMarca.Text = My.Resources.cat.BTModificarMarca
            PanelMarcaModificarEliminar.BTEliminarMarca.Text = My.Resources.cat.BTEliminarMarca
            PanelMarcaModificarEliminar.BResfrescar.Text = My.Resources.cat.BResfrescar
            PanelModelAfegir.LMarca.Text = My.Resources.cat.LMarca
            PanelModelAfegir.LModel.Text = My.Resources.cat.LModel
            PanelModelAfegir.LNExtrusors.Text = My.Resources.cat.LNExtru
            PanelModelAfegir.LTempMaxExt.Text = My.Resources.cat.LTempMaxExt
            PanelModelAfegir.LTempMinExt.Text = My.Resources.cat.LTempMinExt
            PanelModelAfegir.LTempMaxLlit.Text = My.Resources.cat.LTempMaxLlit
            PanelModelAfegir.LTempMinLlit.Text = My.Resources.cat.LTempMinLlit
            PanelModelAfegir.LAreaX.Text = My.Resources.cat.LAreaX
            PanelModelAfegir.LAreaY.Text = My.Resources.cat.LAreaY
            PanelModelAfegir.LAreaZ.Text = My.Resources.cat.LAreaZ
            PanelModelAfegir.LVelMaxExt.Text = My.Resources.cat.LVelMaxExt
            PanelModelAfegir.LResMinCapa.Text = My.Resources.cat.LResMinCapa
            PanelModelAfegir.LResMaxCapa.Text = My.Resources.cat.LResMaxCapa
            PanelModelAfegir.LDiametreFil.Text = My.Resources.cat.LDiametreFil
            PanelModelAfegir.LMaterialSup.Text = My.Resources.cat.LMaterialsSup
            PanelModelAfegir.BTAfegir.Text = My.Resources.cat.BTAfegir
            PanelModelAfegir.BTBorrar.Text = My.Resources.cat.BTBorrar
            PanelModelModificarEliminar.BTModificarModel.Text = My.Resources.cat.BTModificarModel
            PanelModelModificarEliminar.BTEliminarModel.Text = My.Resources.cat.BTEliminarModel
            PanelModelModificarEliminar.BResfrescar.Text = My.Resources.cat.BResfrescar
            PanelModificarEliminarUsuaris.BTModificarUsuari.Text = My.Resources.cat.BTModificarUsuari
            PanelModificarEliminarUsuaris.BTEliminarUsuari.Text = My.Resources.cat.BTEliminarUsuari
            PanelModificarEliminarUsuaris.BResfrescar.Text = My.Resources.cat.BResfrescar
            PanelUsuarisAfegir.LNomUsuari.Text = My.Resources.cat.LNomUsuari
            PanelUsuarisAfegir.LNom.Text = My.Resources.cat.LNom
            PanelUsuarisAfegir.LCognom.Text = My.Resources.cat.LCognom
            PanelUsuarisAfegir.LCorreu.Text = My.Resources.cat.LCorreu
            PanelUsuarisAfegir.LContrasenya.Text = My.Resources.cat.LContrasenya
            PanelUsuarisAfegir.LRContrasenya.Text = My.Resources.cat.LRContra
            PanelUsuarisAfegir.LPermisos.Text = My.Resources.cat.LPermisos
            PanelUsuarisAfegir.BTCrear.Text = My.Resources.cat.BTCrear
            PanelUsuarisAfegir.BTEsborrar.Text = My.Resources.cat.BTBorrar
            CanviarBobina.LImpressora.Text = My.Resources.cat.LImpressora
            CanviarBobina.LBobina.Text = My.Resources.cat.LBobina
            CanviarBobina.BTCanviar.Text = My.Resources.cat.BTCambiarBobina
            CanviarBobina.BTCancelar.Text = My.Resources.cat.BTCancelar
            ImprimirGCODE.LNomGcode.Text = My.Resources.cat.LNomGcode
            ImprimirGCODE.LImpressora.Text = My.Resources.cat.LImpressora
            ImprimirGCODE.LNCopies.Text = My.Resources.cat.LNCopies
            ImprimirGCODE.BTImprimir.Text = My.Resources.cat.BTImprimirG
            ImprimirGCODE.BTImprimirCancelar.Text = My.Resources.cat.BTCancelar
            ModificarBobinesBobina.LDiametre.Text = My.Resources.cat.LDiametre
            ModificarBobinesBobina.LMaterial.Text = My.Resources.cat.LMaterial
            ModificarBobinesBobina.LMarca.Text = My.Resources.eng.LMarcaProductora
            ModificarBobinesBobina.LColor.Text = My.Resources.cat.LColor
            ModificarBobinesBobina.BTAfegir.Text = My.Resources.cat.BTModificarBobina
            ModificarBobinesBobina.BTCancelar.Text = My.Resources.cat.BTCancelar
            ModificarBobinesColor.LColor.Text = My.Resources.cat.LColor
            ModificarBobinesColor.LHex.Text = My.Resources.cat.LHex
            ModificarBobinesColor.BTModificar.Text = My.Resources.cat.CBModificar
            ModificarBobinesColor.BTCancelar.Text = My.Resources.cat.BTCancelar
            ModificarBobinesMarca.LMarcaProductora.Text = My.Resources.cat.LMarcaProductora
            ModificarBobinesMarca.BTModificar.Text = My.Resources.cat.CBModificar
            ModificarBobinesMarca.BTCancelar.Text = My.Resources.cat.BTCancelar
            ModificarBobinesMaterial.LMaterial.Text = My.Resources.cat.LMaterial
            ModificarBobinesMaterial.LTecnic.Text = My.Resources.cat.LTecnic
            ModificarBobinesMaterial.BTModificar.Text = My.Resources.cat.CBModificar
            ModificarBobinesMaterial.BTBorrar.Text = My.Resources.cat.BTCancelar
            ModificarMarca.LMarca.Text = My.Resources.cat.LMarca
            ModificarMarca.BTModificar.Text = My.Resources.cat.CBModificar
            ModificarMarca.BTCancelar.Text = My.Resources.cat.BTCancelar
            ModificarGcode.LNomGcode.Text = My.Resources.cat.LNomGcode
            ModificarGcode.LRutaFich.Text = My.Resources.cat.LRutaFich
            ModificarGcode.LMaterialsSup.Text = My.Resources.cat.LMaterialsSup
            ModificarGcode.BTModificar.Text = My.Resources.cat.CBModificar
            ModificarGcode.BTCancelar.Text = My.Resources.cat.BTCancelar
            ModificarImpressores.LMarca.Text = My.Resources.cat.LMarca
            ModificarImpressores.LModel.Text = My.Resources.cat.LModel
            ModificarImpressores.LNom.Text = My.Resources.cat.LNom
            ModificarImpressores.BTImpressoraGuardar.Text = My.Resources.cat.BTGuardar
            ModificarImpressores.BTCancelar.Text = My.Resources.cat.BTCancelar
            ModificarModel.LMarca.Text = My.Resources.cat.LMarca
            ModificarModel.LModel.Text = My.Resources.cat.LModel
            ModificarModel.LNExtru.Text = My.Resources.cat.LNExtru
            ModificarModel.LTempMaxExt.Text = My.Resources.cat.LTempMaxExt
            ModificarModel.LTempMinExt.Text = My.Resources.cat.LTempMinExt
            ModificarModel.LTempMaxLlit.Text = My.Resources.cat.LTempMaxLlit
            ModificarModel.LTempMinLlit.Text = My.Resources.cat.LTempMinLlit
            ModificarModel.LAreaX.Text = My.Resources.cat.LAreaX
            ModificarModel.LAreaY.Text = My.Resources.cat.LAreaY
            ModificarModel.LAreaZ.Text = My.Resources.cat.LAreaZ
            ModificarModel.LVelMaxExt.Text = My.Resources.cat.LVelMaxExt
            ModificarModel.LResMinCapa.Text = My.Resources.cat.LResMinCapa
            ModificarModel.LResMaxCapa.Text = My.Resources.cat.LResMaxCapa
            ModificarModel.LDiametre.Text = My.Resources.cat.LDiametre
            ModificarModel.LMaterialSup.Text = My.Resources.cat.LMaterialsSup
            ModificarModel.BTModificar.Text = My.Resources.cat.CBModificar
            ModificarModel.BTCancelar.Text = My.Resources.cat.BTCancelar
            ModificarUsuari.LNomUsuari.Text = My.Resources.cat.LNomUsuari
            ModificarUsuari.LNom.Text = My.Resources.cat.LNom
            ModificarUsuari.LCognom.Text = My.Resources.cat.LCognom
            ModificarUsuari.LCorreu.Text = My.Resources.cat.LCorreu
            ModificarUsuari.LContrasenya.Text = My.Resources.cat.LContrasenya
            ModificarUsuari.LRepeteixContra.Text = My.Resources.cat.LRContra
            ModificarUsuari.LabelNovaContraseña.Text = My.Resources.cat.LNova
            ModificarUsuari.BTCancelar.Text = My.Resources.cat.BTCancelar
            ModificarUsuari.BTModificar.Text = My.Resources.cat.CBModificar
            ModificarUsuari.ButtonModConstraseña.Text = My.Resources.cat.BTModificarUsuari

            MenuPrincipal.user.Items.Add(opcio1)
            MenuPrincipal.user.Items.Add(opcio2)
            MenuPrincipal.user.Items.Add(opcio3)
            MenuPrincipal.user.Items.Add(opcio4)
        Else
            MenuPrincipal.user.Items.Clear()
            opcio1 = My.Resources.eng.opcioPerfil
            opcio2 = My.Resources.eng.opcioCambiarIdioma
            opcio3 = My.Resources.eng.opcioSortir
            opcio4 = My.Resources.eng.opcioGenerarEstadistiques
            MenuPrincipal.LBControl.Text = My.Resources.eng.LBControl
            MenuPrincipal.LBGestio.Text = My.Resources.eng.LBGestio
            MenuPrincipal.LBImpressions.Text = My.Resources.eng.LBImpressions
            MenuPrincipal.LBImpressores.Text = My.Resources.eng.LBImpressores
            MenuPrincipal.LBInici.Text = My.Resources.eng.LInici
            Login.Lidioma.Text = My.Resources.eng.Lidioma
            Login.LUsuari.Text = My.Resources.eng.LUsuari
            Login.LContrasenya.Text = My.Resources.eng.LContrasenya
            Login.CBRecordar.Text = My.Resources.eng.CBRecordar
            Login.ButtonLogin.Text = My.Resources.eng.ButtonLogin
            Login.LabelErrorLogin.Text = My.Resources.eng.LabelErrorLogin

            MenuPrincipal.LBUsuaris.Text = My.Resources.eng.LUsuaris
            MenuPrincipal.LBBobines.Text = My.Resources.eng.LBobines
            MenuPrincipal.LBModelsCar.Text = My.Resources.eng.LModels
            MenuPrincipal.LBGCode.Text = My.Resources.eng.LGcode

            FUsuaris.BTAfegir.Text = My.Resources.eng.BTAfegir
            FUsuaris.BTModificarEliminar.Text = My.Resources.eng.BTModificarEliminar

            FBobines.LBobina.Text = My.Resources.eng.LBobina
            FBobines.LColor.Text = My.Resources.eng.LColor
            FBobines.LMarca.Text = My.Resources.eng.LMarca
            FBobines.LMaterial.Text = My.Resources.eng.LMaterial
            FBobines.BTBobinaAfegir.Text = My.Resources.eng.BTAfegir
            FBobines.BTBobinaModif.Text = My.Resources.eng.BTModificarBobina
            FBobines.BTColorAfegir.Text = My.Resources.eng.BTAfegir
            FBobines.BTColorModif.Text = My.Resources.eng.BTModificarColor
            FBobines.BTMarcaAfegir.Text = My.Resources.eng.BTAfegir
            FBobines.BTMarcaModif.Text = My.Resources.eng.BTModificarMarca
            FBobines.BTMaterialAfegir.Text = My.Resources.eng.BTAfegir
            FBobines.BTMaterialModif.Text = My.Resources.eng.BTModificarMaterial
            FCambIdiom.LSelecionarIdioma.Text = My.Resources.eng.LSelecionarIdioma
            FGcode.BTAfegir.Text = My.Resources.eng.BTAfegir
            FGcode.BTModificarEliminar.Text = My.Resources.eng.BTModificarEliminar
            FImpressions.BTCancelar.Text = My.Resources.eng.BTCancelar
            FImpressions.BTImpressionsPeçaRetirada.Text = My.Resources.eng.BTImpressionsPeçaRetirada
            FImpressions.BTImprimirG.Text = My.Resources.eng.BTImprimirG
            FImpressions.BResfrescar.Text = My.Resources.eng.BResfrescar
            FImpressores.BTConnectar.Text = My.Resources.eng.BTConnectar
            FImpressores.BTLlista.Text = My.Resources.eng.BTLlista
            FInici.LBenvingut.Text = My.Resources.eng.LBenvingut
            FInici.LApliFun.Text = My.Resources.eng.LApliFun
            FInici.LControl.Text = My.Resources.eng.LControl
            FInici.LGestio.Text = My.Resources.eng.LGestio
            FInici.LImpressores.Text = My.Resources.eng.LBImpressores
            FInici.LImpressions.Text = My.Resources.eng.LBImpressions
            FInici.LUsuaris.Text = My.Resources.eng.LUsuaris
            FInici.LModels.Text = My.Resources.eng.LModels
            FInici.LGcode.Text = My.Resources.eng.LGcode
            FInici.LBobines.Text = My.Resources.eng.LBobines
            FModels.LMarca.Text = My.Resources.eng.LMarca
            FModels.LModel.Text = My.Resources.eng.LModel
            FModels.BTMarcaAfegir.Text = My.Resources.eng.BTAfegir
            FModels.BTMarcaModificar.Text = My.Resources.eng.BTModificarMarca
            FModels.BTModelAfegir.Text = My.Resources.eng.BTAfegir
            FModels.BTModelModificar.Text = My.Resources.eng.BTModificarModel
            FPerfil.LDades.Text = My.Resources.eng.LDades
            FPerfil.CBModificar.Text = My.Resources.eng.CBModificar
            FPerfil.LDni.Text = My.Resources.eng.LDni
            FPerfil.LNom.Text = My.Resources.eng.LNom
            FPerfil.LCognom.Text = My.Resources.eng.LCognom
            FPerfil.LEmail.Text = My.Resources.eng.LEmail
            FPerfil.LCanvContr.Text = My.Resources.eng.LCanvContr
            FPerfil.LActual.Text = My.Resources.eng.LActual
            FPerfil.LNova.Text = My.Resources.eng.LNova
            FPerfil.LRContra.Text = My.Resources.eng.LRContra
            FPerfil.BTCanviarContra.Text = My.Resources.eng.CanviarContrasenya
            FPerfil.BTActualitzar.Text = My.Resources.eng.BTActualitzar
            PanelBobinesBobinaAfegir.LDiametre.Text = My.Resources.eng.LDiametre
            PanelBobinesBobinaAfegir.BTAfegir.Text = My.Resources.eng.BTAfegir
            PanelBobinesBobinaAfegir.BTBorrar.Text = My.Resources.eng.BTBorrar
            PanelBobinesBobinaAfegir.LMaterial.Text = My.Resources.eng.LMaterial
            PanelBobinesBobinaAfegir.LMarca.Text = My.Resources.eng.LMarca
            PanelBobinesBobinaAfegir.LColor.Text = My.Resources.eng.LColor
            PanelBobinesBobinaModificarEliminar.BTModificarBobina.Text = My.Resources.eng.BTModificarBobina
            PanelBobinesBobinaModificarEliminar.BTEliminarBobina.Text = My.Resources.eng.BTEliminarBobina
            PanelBobinesBobinaModificarEliminar.BResfrescar.Text = My.Resources.eng.BResfrescar
            PanelBobinesColorAfegir.LColor.Text = My.Resources.eng.LColor
            PanelBobinesColorAfegir.LHex.Text = My.Resources.eng.LHex
            PanelBobinesColorAfegir.BTAfegir.Text = My.Resources.eng.BTAfegir
            PanelBobinesColorAfegir.BTBorrar.Text = My.Resources.eng.BTBorrar
            PanelBobinesColorModificarEliminar.BTModificarColor.Text = My.Resources.eng.BTModificarColor
            PanelBobinesColorModificarEliminar.BTEliminarColor.Text = My.Resources.eng.BTEliminarColor
            PanelBobinesColorModificarEliminar.BResfrescar.Text = My.Resources.eng.BResfrescar
            PanelBobinesMarcaAfegir.LMarcaProductora.Text = My.Resources.eng.LMarcaProductora
            PanelBobinesMarcaAfegir.BTAfegir.Text = My.Resources.eng.BTAfegir
            PanelBobinesMarcaAfegir.BTBorrar.Text = My.Resources.eng.BTBorrar
            PanelBobinesMarcaModificarEliminar.BTModificarMarca.Text = My.Resources.eng.BTModificarMarca
            PanelBobinesMarcaModificarEliminar.BTEliminarMarca.Text = My.Resources.eng.BTEliminarMarca
            PanelBobinesMarcaModificarEliminar.BResfrescar.Text = My.Resources.eng.BResfrescar
            PanelBobinesMaterialAfegir.LMaterial.Text = My.Resources.eng.LMaterial
            PanelBobinesMaterialAfegir.LTecnic.Text = My.Resources.eng.LTecnic
            PanelBobinesMaterialAfegir.BTAfegir.Text = My.Resources.eng.BTAfegir
            PanelBobinesMaterialAfegir.BTBorrar.Text = My.Resources.eng.BTBorrar
            PanelBobinesMaterialModificarEliminar.BTEliminarMaterial.Text = My.Resources.eng.BTEliminarMaterial
            PanelBobinesMaterialModificarEliminar.BTModificarMaterial.Text = My.Resources.eng.BTModificarMaterial
            PanelBobinesMaterialModificarEliminar.BResfrescar.Text = My.Resources.eng.BResfrescar
            PanelConnectarNovaImpressora.LModel.Text = My.Resources.eng.LModel
            PanelConnectarNovaImpressora.LMarca.Text = My.Resources.eng.LMarca
            PanelConnectarNovaImpressora.LNom.Text = My.Resources.eng.LNom
            PanelConnectarNovaImpressora.LBobina.Text = My.Resources.eng.LBobina
            PanelConnectarNovaImpressora.BTImpressoraGuardar.Text = My.Resources.eng.BTGuardar
            PanelConnectarNovaImpressora.BTImpressoraBorrar.Text = My.Resources.eng.BTBorrar
            PanelGcodeAfegir.LNomGcode.Text = My.Resources.eng.LNomGcode
            PanelGcodeAfegir.LMaterialsSup.Text = My.Resources.eng.LMaterialsSup
            PanelGcodeAfegir.LRuta.Text = My.Resources.eng.LRutaFich
            PanelGcodeAfegir.BTAfegir.Text = My.Resources.eng.BTAfegir
            PanelGcodeAfegir.BTBorrar.Text = My.Resources.eng.BTBorrar
            PanelGcodeModificarEliminar.BTModificarGcode.Text = My.Resources.eng.BTModificarGcode
            PanelGcodeModificarEliminar.BTEliminarGcode.Text = My.Resources.eng.BTEliminarGcode
            PanelGcodeModificarEliminar.BResfrescar.Text = My.Resources.eng.BResfrescar
            PanelLlistaImpressores.BTCambiarBobina.Text = My.Resources.eng.BTCambiarBobina
            PanelLlistaImpressores.BTModificarImpressora.Text = My.Resources.eng.BTModificarImpressora
            PanelLlistaImpressores.BTEliminarImpressora.Text = My.Resources.eng.BTEliminarImpressora
            PanelLlistaImpressores.BResfrescar.Text = My.Resources.eng.BResfrescar
            PanelMarcaAfegir.LMarca.Text = My.Resources.eng.LMarca
            PanelMarcaAfegir.BTAfegir.Text = My.Resources.eng.BTAfegir
            PanelMarcaAfegir.BTBorrar.Text = My.Resources.eng.BTBorrar
            PanelMarcaModificarEliminar.BTModificarMarca.Text = My.Resources.eng.BTModificarMarca
            PanelMarcaModificarEliminar.BTEliminarMarca.Text = My.Resources.eng.BTEliminarMarca
            PanelMarcaModificarEliminar.BResfrescar.Text = My.Resources.eng.BResfrescar
            PanelModelAfegir.LMarca.Text = My.Resources.eng.LMarca
            PanelModelAfegir.LModel.Text = My.Resources.eng.LModel
            PanelModelAfegir.LNExtrusors.Text = My.Resources.eng.LNExtru
            PanelModelAfegir.LTempMaxExt.Text = My.Resources.eng.LTempMaxExt
            PanelModelAfegir.LTempMinExt.Text = My.Resources.eng.LTempMinExt
            PanelModelAfegir.LTempMaxLlit.Text = My.Resources.eng.LTempMaxLlit
            PanelModelAfegir.LTempMinLlit.Text = My.Resources.eng.LTempMinLlit
            PanelModelAfegir.LAreaX.Text = My.Resources.eng.LAreaX
            PanelModelAfegir.LAreaY.Text = My.Resources.eng.LAreaY
            PanelModelAfegir.LAreaZ.Text = My.Resources.eng.LAreaZ
            PanelModelAfegir.LVelMaxExt.Text = My.Resources.eng.LVelMaxExt
            PanelModelAfegir.LResMinCapa.Text = My.Resources.eng.LResMinCapa
            PanelModelAfegir.LResMaxCapa.Text = My.Resources.eng.LResMaxCapa
            PanelModelAfegir.LDiametreFil.Text = My.Resources.eng.LDiametreFil
            PanelModelAfegir.LMaterialSup.Text = My.Resources.eng.LMaterialsSup
            PanelModelAfegir.BTAfegir.Text = My.Resources.eng.BTAfegir
            PanelModelAfegir.BTBorrar.Text = My.Resources.eng.BTBorrar
            PanelModelModificarEliminar.BTModificarModel.Text = My.Resources.eng.BTModificarModel
            PanelModelModificarEliminar.BTEliminarModel.Text = My.Resources.eng.BTEliminarModel
            PanelModelModificarEliminar.BResfrescar.Text = My.Resources.eng.BResfrescar
            PanelModificarEliminarUsuaris.BTModificarUsuari.Text = My.Resources.eng.BTModificarUsuari
            PanelModificarEliminarUsuaris.BTEliminarUsuari.Text = My.Resources.eng.BTEliminarUsuari
            PanelModificarEliminarUsuaris.BResfrescar.Text = My.Resources.eng.BResfrescar
            PanelUsuarisAfegir.LNomUsuari.Text = My.Resources.eng.LNomUsuari
            PanelUsuarisAfegir.LNom.Text = My.Resources.eng.LNom
            PanelUsuarisAfegir.LCognom.Text = My.Resources.eng.LCognom
            PanelUsuarisAfegir.LCorreu.Text = My.Resources.eng.LCorreu
            PanelUsuarisAfegir.LContrasenya.Text = My.Resources.eng.LContrasenya
            PanelUsuarisAfegir.LRContrasenya.Text = My.Resources.eng.LRContra
            PanelUsuarisAfegir.LPermisos.Text = My.Resources.eng.LPermisos
            PanelUsuarisAfegir.BTCrear.Text = My.Resources.eng.BTCrear
            PanelUsuarisAfegir.BTEsborrar.Text = My.Resources.eng.BTBorrar
            CanviarBobina.LImpressora.Text = My.Resources.eng.LImpressora
            CanviarBobina.LBobina.Text = My.Resources.eng.LBobina
            CanviarBobina.BTCanviar.Text = My.Resources.eng.BTCambiarBobina
            CanviarBobina.BTCancelar.Text = My.Resources.eng.BTCancelar
            ImprimirGCODE.LNomGcode.Text = My.Resources.eng.LNomGcode
            ImprimirGCODE.LImpressora.Text = My.Resources.eng.LImpressora
            ImprimirGCODE.LNCopies.Text = My.Resources.eng.LNCopies
            ImprimirGCODE.BTImprimir.Text = My.Resources.eng.BTImprimirG
            ImprimirGCODE.BTImprimirCancelar.Text = My.Resources.eng.BTCancelar
            ModificarBobinesBobina.LDiametre.Text = My.Resources.eng.LDiametre
            ModificarBobinesBobina.LMaterial.Text = My.Resources.eng.LMaterial
            ModificarBobinesBobina.LMarca.Text = My.Resources.eng.LMarcaProductora
            ModificarBobinesBobina.LColor.Text = My.Resources.eng.LColor
            ModificarBobinesBobina.BTAfegir.Text = My.Resources.eng.BTModificarBobina
            ModificarBobinesBobina.BTCancelar.Text = My.Resources.eng.BTCancelar
            ModificarBobinesColor.LColor.Text = My.Resources.eng.LColor
            ModificarBobinesColor.LHex.Text = My.Resources.eng.LHex
            ModificarBobinesColor.BTModificar.Text = My.Resources.eng.CBModificar
            ModificarBobinesColor.BTCancelar.Text = My.Resources.eng.BTCancelar
            ModificarBobinesMarca.LMarcaProductora.Text = My.Resources.eng.LMarcaProductora
            ModificarBobinesMarca.BTModificar.Text = My.Resources.eng.CBModificar
            ModificarBobinesMarca.BTCancelar.Text = My.Resources.eng.BTCancelar
            ModificarBobinesMaterial.LMaterial.Text = My.Resources.eng.LMaterial
            ModificarBobinesMaterial.LTecnic.Text = My.Resources.eng.LTecnic
            ModificarBobinesMaterial.BTModificar.Text = My.Resources.eng.CBModificar
            ModificarBobinesMaterial.BTBorrar.Text = My.Resources.eng.BTCancelar
            ModificarMarca.LMarca.Text = My.Resources.eng.LMarca
            ModificarMarca.BTModificar.Text = My.Resources.eng.CBModificar
            ModificarMarca.BTCancelar.Text = My.Resources.eng.BTCancelar
            ModificarGcode.LNomGcode.Text = My.Resources.eng.LNomGcode
            ModificarGcode.LRutaFich.Text = My.Resources.eng.LRutaFich
            ModificarGcode.LMaterialsSup.Text = My.Resources.eng.LMaterialsSup
            ModificarGcode.BTModificar.Text = My.Resources.eng.CBModificar
            ModificarGcode.BTCancelar.Text = My.Resources.eng.BTCancelar
            ModificarImpressores.LMarca.Text = My.Resources.eng.LMarca
            ModificarImpressores.LModel.Text = My.Resources.eng.LModel
            ModificarImpressores.LNom.Text = My.Resources.eng.LNom
            ModificarImpressores.BTImpressoraGuardar.Text = My.Resources.eng.BTGuardar
            ModificarImpressores.BTCancelar.Text = My.Resources.eng.BTCancelar
            ModificarModel.LMarca.Text = My.Resources.eng.LMarca
            ModificarModel.LModel.Text = My.Resources.eng.LModel
            ModificarModel.LNExtru.Text = My.Resources.eng.LNExtru
            ModificarModel.LTempMaxExt.Text = My.Resources.eng.LTempMaxExt
            ModificarModel.LTempMinExt.Text = My.Resources.eng.LTempMinExt
            ModificarModel.LTempMaxLlit.Text = My.Resources.eng.LTempMaxLlit
            ModificarModel.LTempMinLlit.Text = My.Resources.eng.LTempMinLlit
            ModificarModel.LAreaX.Text = My.Resources.eng.LAreaX
            ModificarModel.LAreaY.Text = My.Resources.eng.LAreaY
            ModificarModel.LAreaZ.Text = My.Resources.eng.LAreaZ
            ModificarModel.LVelMaxExt.Text = My.Resources.eng.LVelMaxExt
            ModificarModel.LResMinCapa.Text = My.Resources.eng.LResMinCapa
            ModificarModel.LResMaxCapa.Text = My.Resources.eng.LResMaxCapa
            ModificarModel.LDiametre.Text = My.Resources.eng.LDiametre
            ModificarModel.LMaterialSup.Text = My.Resources.eng.LMaterialsSup
            ModificarModel.BTModificar.Text = My.Resources.eng.CBModificar
            ModificarModel.BTCancelar.Text = My.Resources.eng.BTCancelar
            ModificarUsuari.LNomUsuari.Text = My.Resources.eng.LNomUsuari
            ModificarUsuari.LNom.Text = My.Resources.eng.LNom
            ModificarUsuari.LCognom.Text = My.Resources.eng.LCognom
            ModificarUsuari.LCorreu.Text = My.Resources.eng.LCorreu
            ModificarUsuari.LContrasenya.Text = My.Resources.eng.LContrasenya
            ModificarUsuari.LRepeteixContra.Text = My.Resources.eng.LRContra
            ModificarUsuari.LabelNovaContraseña.Text = My.Resources.eng.LNova
            ModificarUsuari.BTCancelar.Text = My.Resources.eng.BTCancelar
            ModificarUsuari.BTModificar.Text = My.Resources.eng.CBModificar
            ModificarUsuari.ButtonModConstraseña.Text = My.Resources.eng.BTModificarUsuari

            MenuPrincipal.user.Items.Add(opcio1)
            MenuPrincipal.user.Items.Add(opcio2)
            MenuPrincipal.user.Items.Add(opcio3)
            MenuPrincipal.user.Items.Add(opcio4)
        End If
    End Function
End Class
