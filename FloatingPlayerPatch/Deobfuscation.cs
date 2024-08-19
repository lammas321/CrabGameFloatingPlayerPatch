/* ===================================================================================================== //
 * Bepinex Unhollowed Type Deobfuscation for Crab Game v1.362
 *
 * This isn't a complete deobfuscation, as some types may have more or less uses than its name here
 * suggests, and some types had too little functionality to figure out what their purpose was for if
 * they weren't attached to any Game Objects in any scenes, leaving them with obfuscated names.
 *
 * Some places that could use some work include anything relating to the game's UI and the menu.
 * Additionally, anything to do with sfx and the Misc category could use better names or categorization.
 * Anything that's UNKNOWN or UNUSED could be looked into more to confirm its categorization.
// ===================================================================================================== */



// GeneralUi
global using GeneralUiButton = MonoBehaviourPublicIPointerEnterHandlerIEventSystemHandlerIPointerClickHandlerUnique;
global using GeneralUiHoverEffect = MonoBehaviourPublicIPointerEnterHandlerIEventSystemHandlerIPointerExitHandlerTrteSiBoVeSiUnique;
global using GeneralUiTextAlignment = MonoBehaviourPublicTeteRereUnique;

global using GameUiBackButton = MonoBehaviourPublicBubaUnique;

global using GeneralUiInventory = MonoBehaviourPublicGaitTrcoObplmeObTenIUnique;
global using GeneralUiInventorySortType = MonoBehaviourPublicGaitTrcoObplmeObTenIUnique.EnumNPublicSealedvaDeRa3vUnique;
global using GeneralUiInventoryTabs = MonoBehaviourPublicGaseRabtCoidseCoBousUnique;
global using GeneralUiInventoryItemHover = MonoBehaviourPublicRebaTrliTeTrlinataTeUnique;
global using GeneralUiInventoryItemClick = MonoBehaviourPublicGapaCacaTrCacawiReSiUnique;
global using GeneralUiInventoryItem = MonoBehaviourPublicGaitTrcoObplmeObTenIUnique.ObjectNPrivateSealedInitUIObitprObUnique;

global using GeneralUiSettings = MonoBehaviourPublicBubaObcafoObseingrObUnique;
global using GeneralUiSettingsTypeCheckbox = MonoBehaviourPublicBubaObcafoObseingrObUnique.EnumNPublicSealedvaOfOn3vUnique;
global using GeneralUiSettingsTypeVSync = MonoBehaviourPublicBubaObcafoObseingrObUnique.EnumNPublicSealedvaOfAlHa4vUnique;
global using GeneralUiSettingsTypeShadowQuality = MonoBehaviourPublicBubaObcafoObseingrObUnique.EnumNPublicSealedvaOfHaSo4vUnique;
global using GeneralUiSettingsTypeShadowResolution = MonoBehaviourPublicBubaObcafoObseingrObUnique.EnumNPublicSealedvaLoMeHiUl5v0;
global using GeneralUiSettingsTypeShadowDistance = MonoBehaviourPublicBubaObcafoObseingrObUnique.EnumNPublicSealedvaLoMeHiUl5v1;
global using GeneralUiSettingsTypeShadowCascades = MonoBehaviourPublicBubaObcafoObseingrObUnique.EnumNPublicSealedvaNoTwFo4vUnique;
global using GeneralUiSettingsTypeTextureResolution = MonoBehaviourPublicBubaObcafoObseingrObUnique.EnumNPublicSealedvaLoMeHiUl5v2;
global using GeneralUiSettingsTypeAntiAliasing = MonoBehaviourPublicBubaObcafoObseingrObUnique.EnumNPublicSealedvaOfx2x4x85vUnique;
global using GeneralUiSettingsTypeBloom = MonoBehaviourPublicBubaObcafoObseingrObUnique.EnumNPublicSealedvaOfFa4vFaUnique;
global using GeneralUiSettingsTypeMicrophoneUsage = MonoBehaviourPublicBubaObcafoObseingrObUnique.EnumNPublicSealedvaOfHoVo4vUnique;
global using GeneralUiSettingsOnClickHandler = MonoBehaviourPublicIncuObm_ObUnique; // May be used for more, but seems to mostly be used by settings
global using GeneralUiSettingsOnClickEvent = MonoBehaviourPublicIncuObm_ObUnique.UnityEventNPublicUnique; // Same
global using GeneralUiSettingsGameplayResetSave = MonoBehaviourPublicVoReVoVoVoVoVoVoVoVoUnique;
global using GeneralUiSettingsAudioMicSetting = MonoBehaviourPublicTemiUnique;
global using GeneralUiSettingsAudioMicDropDown = MonoBehaviour1PublicTMdrTeseLi1StUnique;
global using GeneralUiSettingsCheckbox = MonoBehaviour1PublicGachUnique;
global using GeneralUiSettingsDropDown = MonoBehaviour1PublicTMdrTeseReUnique;
global using GeneralUiSettingsDropDownItem = MonoBehaviourPublicTrcoGaalObInQu1drObUnique.ObjectNPublicUICoDi2StStUnique;
global using GeneralUiSettingsKeyInput = MonoBehaviour1PublicTekeIncuStUnique;
global using GeneralUiSettingsKeyInputAlert = MonoBehaviourPublicObcuTealGaovBoInObBoUnique;
global using GeneralUiSettingsScroll = MonoBehaviour1PublicTeseStRascRascUnique;
global using GeneralUiSettingsSlider = MonoBehaviour1PublicSlslTevaUnique;
global using GeneralUiSettingsResolution = MonoBehaviour1PublicRascTeRascseReUnique;

global using GeneralUiShadowMeshModifier = ShadowPublicUnique; // Not entirely sure what this is for, didn't come across it on any Game Objects by scanning all of the game's scenes, but it probably has to be used somewhere
global using GeneralUiBaseMeshEffectModifier = BaseMeshEffectPublicCom_VeBom_Li1UIm_CoUnique; // Same with this



// Menu
global using MenuCameraPositioner = MonoBehaviourPublicObcaCaSicacoSiVeQuSiUnique;
global using MenuCameraIdle = MonoBehaviourPublicSispsiSifrVeSiUnique;

global using MenuUi = MonoBehaviourPublicGalomeGacrsemiGaupObUnique;
global using MenuUiVersion = MonoBehaviourPublicTeveObInUnique;
global using MenuUiItemStore = MonoBehaviourPublicObcoTeciInCoGaInloprUnique;
global using MenuUiItemStoreItem = MonoBehaviourPublicObcoTeciInCoGaInloprUnique.ObjectNPublicIComparableStInUIUnique;
global using MenuUiDailyQuest = MonoBehaviourPublicGachbuGaTebuqutiGaTeUnique;

global using MenuUiCreateLobbySettings = MonoBehaviourPublicObjomaOblogaTMObseprUnique;
global using MenuUiCreateLobbyGameModesAndMaps = MonoBehaviourPublicGamomaGaTrmoTrmaUnique;
global using MenuUiCreateLobbyPractice = MonoBehaviourPublicGamaTrInmanoGaprsrVo0;

global using MenuUiServerList = MonoBehaviourPublicGaseliGaVibuToclmiToUnique;
global using MenuUiServerListCodeInput = MonoBehaviourPublicTMinUnique;
global using MenuUiServerListing = MonoBehaviourPublicRaprTetiplTelovemiTeUnique;
global using MenuUiServerListingGameModesAndMaps = MonoBehaviourPublicIPointerEnterHandlerIEventSystemHandlerIPointerExitHandlerObseStStUnique;
global using MenuUiServerListingGameModesAndMapsInfo = MonoBehaviourPublicGaprTrmomaTrTehegaGaUnique;

global using MenuUiItemsDisplay = MonoBehaviourPublicObcoTeciInSiInLi1TrUnique;
global using MenuUiItemsDisplayDetails = MonoBehaviourPublicIPointerEnterHandlerIEventSystemHandlerIPointerExitHandlerRaicbgRashovTeRaitquUnique;
global using MenuUiRecycleItem = MonoBehaviourPublicGareTecoObinpaGaIninUnique;
global using MenuUiRecycleItemDisplay = MonoBehaviourPublicTeteTritMeMaitMeyiQuUnique;
global using MenuUiRecycleItemDisplaySpin = MonoBehaviourPublicIPointerDownHandlerIEventSystemHandlerIPointerUpHandlerSiVeTrobBoUnique;
global using MenuUiCrafting = MonoBehaviourPublicRacrbuRaBuIncrTeraprUnique;
global using MenuUiCrateRates = MonoBehaviourPublicTeVoAwSlVoVoVoVoVoVoUnique;

global using MenuUiMicPrompt = MonoBehaviourPublicObmiGamaUnique;

global using MenuUiCreditsWindow = MonoBehaviourPublicVoStOpVoStVoStVoStVoUnique;
global using MenuUiCreditsContent = MonoBehaviourPublicIPointerClickHandlerIEventSystemHandlerStStUnique;

global using MenuPlayerCosmetics = MonoBehaviourPublicObPlInObUnique;
global using MenuPlayerDragToSpin = MonoBehaviourPublicSiVeBoUnique;

global using MenuCheckPromoItems = MonoBehaviourPublicInprUnique;

global using MenuSnowSpeedModdingDetector = MonoBehaviourPublicVesnUnique;



// GameUi
global using GameUi = MonoBehaviourPublicGaroloGaObInCacachGaUnique;
global using GameUiCrosshair = MonoBehaviourPublicRedoleReritoboReBoenUnique;
global using GameUiCrosshairReloadProgress = MonoBehaviourPublicRacuObInSiSiUnique;
global using GameUiDamageVignette = MonoBehaviourPublicRadaSiSiSiUnique;
global using GameUiGoldVignette = MonoBehaviourPublicGaviObInUnique;
global using GameUiStandoffVignette = MonoBehaviourPublicRaviAusfhiAumicaObAuUnique;
global using GameUiIntro = MonoBehaviourPublicGapaTenagaTedeObInTeUnique;
global using GameUiReward = MonoBehaviourPublicRaliTehereTeTrtoboTrUnique;
global using GameUiTimer = MonoBehaviourPublicTetifrTeStBoStfoSiTiUnique;

global using GameUiStatus = MonoBehaviourPublicObhpamObTeplcoTeloreUnique;
global using GameUiStatusReadyCountdown = MonoBehaviourPublicTeSiBoUnique;
global using GameUiStatusTopRight = MonoBehaviourPublicGaplTeGaplhnTeCoreplUnique;
global using GameUiStatusTopRightHatKingScore = MonoBehaviourPublicTescneTeRaovCosadaCo0;
global using GameUiStatusTopRightKingOfTheHillScore = MonoBehaviourPublicTescneTeRaovCosadaCo1;
global using GameUiStatusTopRightRaceFinishers = MonoBehaviourPublicTescRaovCosadaCoObObUnique;
global using GameUiStatusTopRightStandoffPenalties = MonoBehaviourPublicTescplTeRaovCosadaCoUnique;
global using GameUiStatusTopRightTileDriveScores = MonoBehaviourPublicRabaTescteTeObInBoObUnique;
global using GameUiStatusTopRightAlert = MonoBehaviourPublicVeSiBoSimoUnique;
global using GameUiStatusBottomRightMic = MonoBehaviourPublicObRaObicUnique;
global using GameUiStatusBottomRightAmmo = MonoBehaviourPublicImciTetemaTeSiInSiBoUnique;

global using GameUiChatBox = MonoBehaviourPublicRaovTMinTemeColoonCoUnique;
global using GameUiInventory = MonoBehaviourPublicRepoTrinObCacaInObpaUnique;
global using GameUiInventoryItem = MonoBehaviourPublicCacaTeslnaTeRaimseRaUnique;
global using GameUiDebugNet = MonoBehaviourPublicTefpGacoBoSiBoLi1BoUnique;
global using GameUiSharedObjectDebugManager = MonoBehaviourPublicTeteVoUpVoVoVoVoVoVo0;

global using GameUiStation = MonoBehaviourPublicObshGacuInObUnique;
global using GameUiStationBuyWindow = MonoBehaviourPublicGaitshGataTrbaGataTrUnique;
global using GameUiStationBuyWindowTabs = MonoBehaviourPublicTrtabtTrLi1RaGaLi1Unique;
global using GameUiStationBuyWindowTabs_ObjectNPrivateSealedIninObUnique = MonoBehaviourPublicTrtabtTrLi1RaGaLi1Unique.ObjectNPrivateSealedIninObUnique;
global using GameUiStationBuyWindowTabs_ObjectNPrivateSealedObIninUnique = MonoBehaviourPublicTrtabtTrLi1RaGaLi1Unique.ObjectNPrivateSealedObIninUnique;
global using GameUiStationBuyWindowShopItemIPointerHandler = MonoBehaviourPublicIPointerEnterHandlerIEventSystemHandlerIPointerExitHandlerIPointerClickHandlerInItTeitRaTeitcaRaCaUnique;

global using GameUiPause = MonoBehaviourPublicTrpaGasemaGainBoGapaUnique;
global using GameUiPauseMenuInvite = MonoBehaviourPublicTecoRahiUnique;
global using GameUiPauseMenuDailyQuest = MonoBehaviourPublicObqucuObTrcoBoInObUnique;
global using GameUiPausePracticeMapSelection = MonoBehaviourPublicGamaTrmaUnique;
global using GameUiPausePracticeMapSelectionButton = MonoBehaviourPublicGamaTrmaUnique.ObjectNPrivateSealedBubuObUnique;

global using LoadingScreen = MonoBehaviourPublicTeprUIObUIBotiRabamaUnique;
global using LoadingScreenState = MonoBehaviourPublicTeprUIObUIBotiRabamaUnique.EnumNPublicSealedvaLoWaJoWa5vUnique;
global using LoadingScreenThumbnailZoom = MonoBehaviourPublicVoUpVoVoVoVoVoVoVoVo3;
global using LoadingTransition = MonoBehaviourPublicObRaovInObSiSiUnique;
global using LoadingTransitionDelegate = MonoBehaviourPublicObRaovInObSiSiUnique.MulticastDelegateNPublicSealedVoUnique;

global using PlayerList = MonoBehaviourPublicGapaTrconaGaDi2UIObUnique;
global using PlayerListCount = MonoBehaviourPublicTeplUnique;
global using PlayerListPlayer = MonoBehaviourPublicRabaicRaTeusscTepiObUnique;
global using PlayerListManagePlayer = MonoBehaviourPublicTrwiReGakibaGaTeplmuUnique;



// Managers
global using Managers = MonoBehaviourPublicObInVoAwVoVoVoVoVoVoUnique; // Responsible for moving the entire "Managers" Game Object into Don't Destroy On Load
global using GameLoop = MonoBehaviourPublicObInLi1GagasmLi1GaUnique;
global using GameManager = MonoBehaviourPublicDi2UIObacspDi2UIObUnique;
global using LobbyManager = MonoBehaviourPublicCSDi2UIInstObUIloDiUnique;

global using SteamManager = MonoBehaviourPublicObInUIgaStCSBoStcuCSUnique;
global using SteamPacketManager = MonoBehaviourPublicInStInpabyDiInpaby2Unique;

global using CosmeticsManager = MonoBehaviourPublicLi1CoalDi2InitCoUIUnique;
global using CrateRoomManager = MonoBehaviourPublicGacrgrGaTrhiObsfSkreUnique;
global using CrateOpeningDisplayManager = MonoBehaviourPublicObInTeteTrpaAuitraAuUnique;
global using CrateOpeningSfx = MonoBehaviourPublicAuwoopAureAuUnique;
global using EffectManager = MonoBehaviourPublicGataInefObInUnique;
global using PromptManager = MonoBehaviourPublicGaprLi1ObGaprInUnique;
global using Prompt = MonoBehaviourPublicTehefiTeVeSiVeUnique;
global using QuestManager = MonoBehaviourPublicLi1QudaDi2InquQuacUnique;
global using TotallyJustSfxACTk = MonoBehaviourPublicObsfObsfUnique;

global using GameModeManager = MonoBehaviourPublicGadealGaLi1pralObInUnique;
global using MapManager = MonoBehaviourPublicObInMamaLi1plMadeMaUnique;

global using AlertManager = MonoBehaviourPublicGaalTrcoObInUnique;
global using Alert = MonoBehaviourPublicTeteVoStSeVoStVoStVoUnique;
global using ItemManager = MonoBehaviourPublicDi2InItidGamoObInUnique;
global using SharedObjectManager = MonoBehaviourPublicDi2InObInObInUnique;
global using SharedObjectDebugManager = MonoBehaviourPublicLi1ObUnique;
global using SpawnManager = MonoBehaviourPublicObInGaspUnique;
global using WinManager = MonoBehaviourPublicTenaprTeotplUITeStprUnique;

global using ServerClock = MonoBehaviourPublicSiObSiInSiUnique;


global using PPController = MonoBehaviourPublicMoBlAmChPoObInUnique;
global using PersistentPlayerData = MonoBehaviourPublicBofrhnBoObInUnique;
global using PlayerStatus = MonoBehaviourPublicObcumaObInplInObUnique;
global using PlayerDamageType = MonoBehaviourPublicObcumaObInplInObUnique.EnumNPublicSealedvaFa2vUnique;
global using PunchPlayers = MonoBehaviourPublicObsfBoLawhSiUnique;
global using LocalAudioSource = MonoBehaviourPublicAuhibuAusoObInAuUnique;

// A lot of this Dissonance stuff was skimmed over, names may not be entirely accurate
global using DissonanceInitializer = MonoBehaviourPublicGadiUnique;
global using Dissonance = MonoBehaviourPublicObdicoObInGaObdiUnique;
global using DissonanceP2P = MonoBehaviour1PublicIn_cObIn_cObInInUnique;
global using DissonanceSource = MonoBehaviourPublicAusoMeInObInInInInUnique;
global using DissonanceNetworking = Object1PublicObByCSTiDaLiBy1CSUnique;
global using DissonanceNetworking2 = Object1PublicObByUnique;
global using DissonanceTracking = MonoBehaviourPublicBoStBoObVeStQuObBoUnique;
global using DissonancePlayerPrefabInitializer = MonoBehaviourPublicUIObGaDi2StVeObQuDaUnique;
global using DissonanceSomethingTarget = MonoBehaviourPublicObChSiVeQuBoVeQuSiUnique;



// Steam Inventory
global using SteamInventory = MonoBehaviourPublicStCaSt1ObSthaUIStmaUnique;
global using SteamInventoryCallbackType = MonoBehaviourPublicStCaSt1ObSthaUIStmaUnique.EnumNPublicSealedvaGeSeDeItGeExStDaPlUnique;
global using SteamInventoryCosmeticItem = MonoBehaviourPublicStCaSt1ObSthaUIStmaUnique.ObjectNPublicIComparableStDi2InStStUnique;
global using SteamInventoryPlayerInventory = MonoBehaviourPublicStCaSt1ObSthaUIStmaUnique.ObjectNPublicByObUIUnique;

global using UpdateInventoryInGame = MonoBehaviourPublicStUnique;

global using WorkshopUtility = MonoBehaviourPublicStwodeStUnique;



// Networking
global using Packet = ObjectPublicIDisposableLi1ByInByBoUnique;

global using SteamServerPacketHandler = MonoBehaviourPublicInStInpabyDiInpaby2Unique.MulticastDelegateNPublicSealedVoUIObUnique; // Handles packets sent from clients to you has the host
global using SteamClientPacketHandler = MonoBehaviourPublicInStInpabyDiInpaby2Unique.MulticastDelegateNPublicSealedVoObUnique; // Handles packets sent from other clients to you
global using SteamPacketDestination = MonoBehaviourPublicInStInpabyDiInpaby2Unique.EnumNPublicSealedvaTo3vToUnique;

global using GameServer = MonoBehaviourPublicObInCoIE85SiAwVoFoCoUnique; // Server to client (usually ends up using ServerSend, but its methods have some other important sync logic for giving items)
global using ServerSend = MonoBehaviourPublicInInUnique; // Server to client
global using ServerSendType = EnumPublicSealedvawesepilorelogasespUnique;
global using ClientHandle = MonoBehaviourPublicUIInUIByUIUnique; // Handles receiving client bound packets
global using ClientSend = MonoBehaviourPublicInpabyInInInUnique; // Client to anyone
global using ClientSendType = EnumPublicSealedvahawesepirepiselostUnique;
global using ServerHandle = MonoBehaviourPublicPlVoUI9GaVoUI9UsPlUnique; // Handles receiving server bound packets

global using NetStatus = MonoBehaviourPublicStLi1InInUnique; // Player ping

global using PlayerCommunication = MonoBehaviourPublicTrrocaTrInSiVeSipoObUnique; // For client to client position and rotation sharing (why did you do this to us Dani, now we have floating players :despair:)
global using PlayerCommunicationDistance = MonoBehaviourPublicTrrocaTrInSiVeSipoObUnique.EnumNPublicSealedvaClMeFaAn5vUnique;

global using LobbyGameState = MonoBehaviourPublicCSDi2UIInstObUIloDiUnique.EnumNPublicSealedvaMeLoPrStGa6vUnique;
global using PlayerDisconnectReason = MonoBehaviourPublicCSDi2UIInstObUIloDiUnique.EnumNPublicSealedvaSeKiBaLo5vUnique;



// Shared Objects and Items
global using SharedObject = MonoBehaviourPublicInidBoskUnique;
global using IInteractable = InterfacePublicAbstractTrVoLoSeVoUIAlCaVoUIUnique;
global using InteractableItem = MonoBehaviour1PublicAbstractItitBoGapiTrrileTrObUnique;
global using InteractableItemMelee = MonoBehaviour2PublicObauTrSiVeSiGahiUnique;
global using InteractableItemGun = MonoBehaviour2PublicTrguGamubuGaSiBoSiUnique;

global using WaitingReadyButton = MonoBehaviour1PublicTrbuObreunObBoVeVeVeUnique;
global using BustlingButtonsButton = MonoBehaviour1PublicInbuBoacAumobtAuVeSiUnique;
global using SteppingStonesFakePiece = MonoBehaviour1PublicGasoglGaVefxUnique;

global using SnowballPile = MonoBehaviour1PublicBoInSiUnique;
global using ThrownSnowball = MonoBehaviour1PublicTrtrGahiRiCoBoItVeBoUnique;


global using ItemType = ItemData.EnumNPublicSealedvaPrSeMeThOtAm7vUnique;

global using MuzzlePrefabOffsetTarget = MonoBehaviourPublicTrtaBokeVeUnique;
global using BulletTrailParticle = MonoBehaviourPublicInPabusmPaGahiUnique;
global using ObjectHitFx = MonoBehaviourPublicAugemeAuObsfUnique;
global using ObjectHitFxType = MonoBehaviourPublicAugemeAuObsfUnique.EnumNPublicSealedvaGeMe3vUnique;
global using ItemHitFx = MonoBehaviourPublicDebublDeGaobplGaUnique;
global using ItemHitFxType = MonoBehaviourPublicDebublDeGaobplGaUnique.EnumNPublicSealedvaObPl3vUnique;



// GameModes and Maps
global using GameModeBaseball = GameModePublicItitUnique;
global using GameModeBlockDrop = GameModePublicObSiInSiSiUnique;
global using GameModeBombTag = GameModePublicInSiLiSiIn1UIObBoUnique;
global using GameModeBustlingButtons = GameModePublicInSiUISiIncuneSiUIBoUnique;
global using GameModeBustlingButtonsState = GameModePublicInSiUISiIncuneSiUIBoUnique.EnumNPublicSealedvaReShRe5vReUnique;
global using GameModeCrabFight = GameModePublicUnique;
global using GameModeDeathFromAbove = GameModePublicRaSiInSiInSiUnique;
global using GameModeDodgeball = GameModePublicLi1UIBoLi1UIUnique;
global using GameModeFloorIsLava = GameModePublicInSiInSiInInUnique;
global using GameModeHatKing = GameModePublicLi1UItaDi2InUIplSiUnique;
global using GameModeHideAndSeek = GameModePublicLi1UIsehiLi1UIDi2Unique;
global using GameModeKingOfTheHill = GameModePublicDi2UIInplSielSiLiInUnique;
global using GameModeLightsOut = GameModePublicSiprBoStBoUnique;
global using GameModePractice = GameModePublicObObUnique;
global using GameModeRace = GameModePublicInquUnique;
global using GameModeRedLightGreenLight = GameModePublicSiBoDi2UIObmoSiroSiUnique;
global using GameModeRedLightGreenLightPlayerInfo = GameModePublicSiBoDi2UIObmoSiroSiUnique.ObjectNPrivateVeQuUnique;
global using GameModeSnowBrawl = GameModePublicInUnique;
global using GameModeStandoff = GameModePublicDi2UIObstBocaSiacwaUnique;
global using GameModeStandoffPlayerInfo = GameModePublicDi2UIObstBocaSiacwaUnique.ObjectNPublicInObInUnique;
global using GameModeSteppingStones = GameModePublicLi1InLi1InUnique;
global using GameModeTag = GameModePublicLi1UIUnique;
global using GameModeTileDrive = GameModePublicDi2UIInidnTInUnique;
global using GameModeState = GameMode.EnumNPublicSealedvaFrPlEnGa5vUnique;
global using GameModeType = GameModeData.EnumNPublicSealedvaWaReBaStTaHiBoLiFaUnique;

global using MapSizeType = Map.EnumNPublicSealedvasmmelaan5vUnique;



// GameMode Multipurpose Components
global using GameModeTimer = ObjectPublicSiBoSiSiSiUnique; // Often used in a field named freezeTimer, but it's actually used for more than that
global using SafeZone = MonoBehaviourPublicLi1ObsaInObUnique; // Used for several game modes: Red Light Green Light, Race, and King of The Hill



// GameMode Specific Components
global using BlockDropBlockManager = MonoBehaviourPublicInwiheInblSiflInblGaUnique;
global using BlockDropBlock = MonoBehaviourPublicRirbMemereMeAusfspAuUnique;

global using BustlingButtonsStageController = MonoBehaviourPublicObbuMafoGaMafoAuGaObUnique;
global using BustlingButtonsStageCollider = MonoBehaviourPublicVepuBoUnique;
global using BustlingButtonsTimerAndIndicator = MonoBehaviourPublicTetinoTeneRacoTeCogrUnique;

global using CrabFightCrabManager = MonoBehaviourPublicGacrspGacrObInGaTrObUnique; // So many components for this game mode :eyes:
global using CrabFightCrabCurrentState = MonoBehaviourPublicGacrspGacrObInGaTrObUnique.EnumNPublicSealedvaWaAtDe4vUnique;
global using CrabFightCrabSpawnAttackType = MonoBehaviourPublicGacrspGacrObInGaTrObUnique.EnumNPublicSealedvaBaSp3vUnique;
global using CrabFightCrabPlayAnimationType = MonoBehaviourPublicGacrspGacrObInGaTrObUnique.EnumNPublicSealedvaJuSlRaSpDoDe7vUnique;
global using CrabFightCrabBossBar = MonoBehaviourPublicSiRaSihpTrpaUnique;
global using CrabFightCrabAnimator = MonoBehaviourPublicGacrshGastcrTrlaGacrUnique;
global using CrabFightCrabEyesFacePlayer = MonoBehaviourPublicTrleriTrhetaSiTrandiUnique;
global using CrabFightCrabAttackHitbox = MonoBehaviourPublicSimimaSioufoupSiIndaUnique;
global using CrabFightCrabAttackWarning = MonoBehaviourPublicVeofLawhPrprVeUnique;
global using CrabFightCrabAttackShake = MonoBehaviourPublicShcaSimaUnique;
global using CrabFightCrabBallAttackController = MonoBehaviourPublicSiIndeSibaInRaVoAw20Unique;
global using CrabFightCrabBallAttack = MonoBehaviourPublicGawaspGaObprObUnique;
global using CrabFightCrabBallAttackFalling = MonoBehaviourPublicGawaSispUnique;
global using CrabFightCrabBallAttackLandingFx = MonoBehaviourPublicGahiBoInInUnique;
global using CrabFightCrabSpikeAttackController = MonoBehaviourPublicSiIndeSibaInRa20Vo20Unique;
global using CrabFightCrabSpikeAttack = MonoBehaviourPublicGawaspGaSiObSiUnique;
global using CrabFightCrabSpikeAttackDamage  = MonoBehaviourPublicSioufoSiupIndaSiBoUnique;

global using DeathFromAboveBlockManager = MonoBehaviourPublicInwiheInblflblVeInPaUnique;
global using DeathFromAboveVoxelRenderer = MonoBehaviourPublicMeLi1VeInLi1SiscSiUnique;
global using DeathFromAboveBlockCollider = MonoBehaviourPublicRiUnique;

global using DodgeballSpawnManager = MonoBehaviourPublicObzoTeswpaTeInObUnique;
global using DodgeballChangeTeamTrigger = MonoBehaviourPublicInteLi1ObObUnique;
global using DodgeballChangeTeam = MonoBehaviourPublicInteLi1ObObUnique;

global using FloorIsLavaPieceManager = MonoBehaviourPublicSipiGaLipi1InGaLi11;
global using FloorIsLavaPiece = MonoBehaviourPublicBoGasobrGaSiSiSiUnique;

global using HatKingScoreboard = MonoBehaviourPublicTescLi15599StCoStcy0;
global using HatKingScoreboardPlayer = MonoBehaviourPublicTescLi15599StCoStcy0.ObjectNPublicIComparable1ObfUIStInUnique;

global using KingOfTheHillScoringVisuals = MonoBehaviourPublicPapsEmemAusfGaObUnique;
global using KingOfTheHillScoreboard = MonoBehaviourPublicTescLi15599StCoStcy1;
global using KingOfTheHillScoreboardPlayer = MonoBehaviourPublicTescLi15599StCoStcy1.ObjectNPublicIComparable1ObfUIStInUnique;

global using RaceGasQuestProgression = MonoBehaviourPublicVoCoOnVoCoVoCoVoCoVo1; // Why wasn't this just a part of the SafeZone component, or why not make the finish its own component and not a SafeZone :skull:

global using RedLightGreenLightStatue = MonoBehaviourPublicQuSiQuTrSiheQuLawhQuUnique;

global using StandoffScoreboard = MonoBehaviourPublicTescLi15580StCoStcyUnique;
global using StandoffScoreboardPlayer = MonoBehaviourPublicTescLi15580StCoStcyUnique.ObjectNPublicIComparable1ObfUIStInUnique;

global using SteppingStonesPieceManager = MonoBehaviourPublicObpiInObUnique;

global using TileDriveTileManager = MonoBehaviourPublicObtionObofDi2ObUIInUnique;
global using TileDriveTile = MonoBehaviourPublicVeMeVemeMaVeTrmoInLiUnique;



// Map Specific Components
global using DormMapAdjustToGamemode = MonoBehaviourPublicGaloliGabuGaUnique;
global using DormMapLightsManager = MonoBehaviourPublicGaliRereAusfObInUnique;
global using DormMapReadyDisplay = MonoBehaviourPublicGaprTrcoDi2UIObLi1Unique;
global using DormMapReadyDisplayPlayer = MonoBehaviourPublicTeusRaovObCorenoCoUnique;
global using DormMapReadyDisplayVotingTimer = MonoBehaviourPublicTeteVoUpVoVoVoVoVoVo1;
global using LankyLavaMapLava = MonoBehaviourPublicVeSioflaSiAulasiBoSiUnique;
global using LavaClimbMapBoulderController = MonoBehaviourPublicTrspGaboSiObInUnique;
global using LavaClimbMapLava = MonoBehaviourPublicVespdeVeSilaUnique;
global using PlainsMapGrass = MonoBehaviourPublicMeCoMeAdIngrVetoInLiUnique;



// Player
global using LobbyPlayer = MonoBehaviourPublicCSstInscpiInUnique;
global using Client = ObjectPublicBoInBoCSItBoInSiBySiUnique;

global using Player = MonoBehaviourPublicCSstReshTrheObplBojuUnique;
global using PlayerMovement = MonoBehaviourPublicGaplfoGaTrorplTrRiBoUnique;
global using PlayerCrouchState = MonoBehaviourPublicGaplfoGaTrorplTrRiBoUnique.EnumNPrivateSealedvaNoCrSl4vUnique;
global using PlayerGroundFriction = MonoBehaviourPublicGaplfoGaTrorplTrRiBoUnique.EnumNPrivateSealedvaGeIc4vIcUnique;
global using PlayerInventory = MonoBehaviourPublicItDi2ObIninInTrweGaUnique;

global using OnlinePlayer = MonoBehaviourPublicObVeSiVeRiSiAnVeanTrUnique;
global using OnlinePlayerSetAnimation = MonoBehaviourPublicObVeSiVeRiSiAnVeanTrUnique.EnumNPublicSealedvaCrMe3vUnique;
global using OnlinePlayerCosmetics = MonoBehaviourPublicSkhafaSkshtobaSkMeMaUnique;

global using OnlinePlayerNameTag = MonoBehaviourPublicTenaBoUnique;
global using OnlinePlayerNameTagFacePlayer = MonoBehaviourPublicVoUpVoVoVoVoVoVoVoVo1;
global using OnlinePlayerHatKingCrownOutline = MonoBehaviourPublicGacrswGapaCoObGacrcoUnique;
global using OnlinePlayerStandoffPenalties = MonoBehaviourPublicTescObpmObInStUnique;

global using OnlinePlayerFootstepDetection = MonoBehaviourPublicGafoBoSiUnique;
global using OnlinePlayerFootstep = MonoBehaviourPublicLawhObraAugegrAuUnique;
global using OnlinePlayerEquippedItem = MonoBehaviourPublicObTritleObriVeQuObVeUnique;
global using OnlinePlayerEquippedItemIK = MonoBehaviourPublicInChTrTaPoTrItInSiDeUnique;

global using OnlinePlayerDissonanceTracker = MonoBehaviourPublicBoloStBoTrorBoObpmSpUnique;
global using OnlinePlayerDissonanceSource = MonoBehaviourPublicSiBoSimudiSiAusofiAuUnique;
global using OnlinePlayerDissonanceJawMovement = MonoBehaviourPublicTrjaObpmObBoObUnique;
global using OnlinePlayerDissonanceTargetMuter = MonoBehaviourPublicTrtaObpmUnique;

global using ExplodedPlayerBodyParts = MonoBehaviourPublicRiboSiUnique; // Created on player death when the killer's steam id is 1 (meaning should explode)
global using DeadPlayerMakeRagdoll = MonoBehaviourPublicObmaReshUnique; // Created on player death when the killer's steam id is not 1 (meaning should make a ragdoll)
global using DeadPlayerCreateRagdoll = MonoBehaviourPublicTrarPhmaUnique; // Part of the process of making a player ragdoll



// Camera
global using CameraController = MonoBehaviourPublicTrplVeofdeVevaCaRiVeUnique;
global using CameraControllerState = MonoBehaviourPublicTrplVeofdeVevaCaRiVeUnique.EnumNPublicSealedvaPlSpPlFr5vUnique;
global using CameraRecoil = MonoBehaviourPublicVeVeUnique;
global using CameraShaker = MonoBehaviourPublicShdaguShpuheObShInShUnique;
global using CameraWeaponPos = MonoBehaviourPublicRiTrVeLi1SiVeweSiTrUnique;
global using CameraFallSfxPlayer = MonoBehaviourPublicObfaInObUnique;
global using CameraWeaponMelee = MonoBehaviourPublicAnObInObUnique;
global using CameraUnderwaterFilter = MonoBehaviourPublicAufiUnique;
global using CameraLerpDesiredFov = MonoBehaviourPublicCacaSideUnique;

global using CameraHighlightPointedInteractable = MonoBehaviourPublicLawhTrcaGacuMaouUnique;
global using CameraRevealPlayerNames = MonoBehaviourPublicLi1ObplLawhRaUnique;

global using CinematicCameraController = MonoBehaviourPublicTrtaBoleSisploBoUnique;
global using CinematicCameraCloser = MonoBehaviourPublicBoObInUnique;
global using CinematicCameraPanning = MonoBehaviourPublicTrtaSispUnique;

global using DepthTextureMode = MonoBehaviourPublicCaUnique; // Sets the DepthTextureMode of the camera it's attached to to Depth



// Win Screen
global using WinScreenCameraController = MonoBehaviourPublicGacaInSiAucamuclAumoUnique;
global using WinScreenSpotlightActivator = MonoBehaviourPublicGaauSitiUnique; // Activates the accompanying spotlight and plays the sound effect for each camera in the sequence
global using WinScreenCameraShaker = MonoBehaviourPublicShshmeShShUnique;
global using WinScreenUiDropAlerts = MonoBehaviourPublicTrcoGaalObInQu1drObUnique;
global using WinScreenUiDropAlert = MonoBehaviourPublicTenaObitStfrStseStUnique;



// Obstacles and Misc Map Components
global using BounceObstacle = MonoBehaviourPublicSicofoSimuupInSiboVeUnique; // Almost anything that knocks you away when you collide with it uses this
global using SlidingObstacle = MonoBehaviourPublicVeofSispRiVeSiofUnique; // Doesn't deal knockback itself, using BounceObstacle, but makes the object move back and forth between 2 positions
global using SpinnerObstacle = MonoBehaviourPublicVeaxSispRiVeofSiBoUnique; // Doesn't deal knockback itself, using BounceObstacle, but makes the object go spiiIIIIIIIIIiiiiiIIIIn
global using TireBounceObstacle = MonoBehaviourPublicSiBopuSiUnique; // Could be used for other vertical launchers, but only used for tire bouces in the game

global using ScrollingGroundController = MonoBehaviourPublicSigrReMagrVetrVeReShUnique; // Used in Toxic Train
global using ScrollingGroundCollider = MonoBehaviourPublicVefoUnique;

global using KillPlayerOnTrigger = MonoBehaviourPublicVoCoOnVoCoVoCoVoCoVo0; // Wasn't able to find a usage in game, but kills the player when they enter a trigger Collider
global using KillPlayerOutOfBounds = MonoBehaviourPublicSikiUnique;
global using LavaDamage = MonoBehaviourPublicGasfUnique;
global using UnderwaterZone = MonoBehaviourPublicVoCoOnVoCoOnVoCoVoCoUnique;

global using SpawnZone = MonoBehaviourPublicVesiUnique;
global using OnlyShowForGameMode = MonoBehaviourPublicObgaGaobUnique;

global using Ladder = MonoBehaviourPublicLi1CoonUnique;

global using CameraFollowingSnowParticles = MonoBehaviourPublicVeofUnique;
global using WaterSplash = MonoBehaviourPublicGaspLi1ObUnique;



// Misc
global using StaticConstants = ObjectPublicInSiInInInInInInInInUnique; // Several static constants used in several parts of Crab Game for different purposes

global using CustomRandom = RandomPublicInInInInInInUnique; // A custom System.Random used in several parts of Crab Game

global using MeshGenerationFrom2dGridHelper = ObjectPublicAbstractSealedVeInUnique; // Seems to be used in the process of generating meshes from 2d grids
global using MeshGeneratedFrom2dGrid = MonoBehaviourPublicMeLi1VeInLi1SiscpoUnique; // Uses the above type in the process of generating itself
global using Direction = EnumPublicSealedvaNoEaSoWeUpDo7vUnique;

global using CosmeticItemUtils = MonoBehaviourPublicStStStStStStStStStStUnique;
global using CosmeticItemType = CosmeticItem.EnumNPublicSealedvaNoHaFaHaShOtBoToBaUnique;
global using CosmeticItemRarity = CosmeticItem.EnumNPublicSealedvaCoUnRaExLeOr8vUnUnique;

global using PlayerClothingColors = MonoBehaviourPublicCoInConCCoCoCoCoCoCoUnique; // Changes the player's undershirt color. The default color is white and the default value in Player.colorId is 0. The method Player.SetColor is never called and Player.colorId is never changed. This has the indirect effect of giving the player a red shirt when they die and become a ragdoll   0 = Red, 1 = Orange, 2 = Yellow, 3 = Lime, 4 = Green, 5 = Spring Green, 6 = Cyan, 7 = Light Blue, 8 = Blue, 9 = Purple, 10 = Magenta, 11 = Pink, 12 = White, 13 = Black

global using QuestType = Quest.EnumNPublicSealedvaChSiSuGaCaBo7vUnique;

global using ChatFilter = MonoBehaviourPublicTeprLi1StUnique;

global using PlayerKeybinds = MonoBehaviourPublicInfobaInlerijuIncrspUnique;

global using LobbyManagerGameSettings = ObjectPublicObInUIInStInUIInInUnique;
global using LobbyManagerGameVisibility = ObjectPublicObInUIInStInUIInInUnique.EnumNPublicSealedvaLoFrPu4vUnique;
global using LobbyManagerGameState = ObjectPublicInBoUnique;

global using MusicController = MonoBehaviourPublicAuInMeAufuscwiAuObSiUnique;
global using SongType = MonoBehaviourPublicAuInMeAufuscwiAuObSiUnique.EnumNPublicSealedvaNoInMeFuScWi7vUnique;

global using DecalPool = MonoBehaviourPublicGadeLi1MeInObInInUnique;
global using DecalPoolDecal = MonoBehaviourPublicGadeLi1MeInObInInUnique.Decal;
global using CombatUtility = MonoBehaviourPublicGadahiGaObInUnique;
global using DamageNumber = MonoBehaviourPublicTeteVeVeUnique;

global using RoundStartSfx = MonoBehaviourPublicAuroObAuroclriAuroObUnique;
global using RoundSfxPlayer = MonoBehaviourPublicAusoSimamiSiBoAuplSiUnique;

global using ObjectOutliner = MonoBehaviourPublicHa1MeObouCoSiouBoprUnique;
global using ObjectOutlineType = MonoBehaviourPublicHa1MeObouCoSiouBoprUnique.EnumNPublicSealedvaOuSiOu6vOuOuUnique;

global using OverrideShadowSettings = MonoBehaviourPublicSiShSiShUnique;

global using DestroyGameObjectAfterTime = MonoBehaviourPublicSitiUnique;

global using StringObfuscator = ObjectPublicStByVoByStByStByStBy5; // Used by Dani to obfuscate some strings, though deobduscating them didn't really find anything interesting *shrug*

global using PlayerRadius = MonoBehaviourPublicSiplUnique; // Only used by GameServer.PlayerSpawnRequest to find an open spawn location for the player, not too close to anything else

global using FindGround = ObjectPublicVeVoVeVeVeVeVeVeVeVeUnique; // Used to find the ground position below a point, usually for finding at what height to spawn a player at

global using FlipTexture = MonoBehaviourPublicTeFlTeVoTeTeTeTeTeTeUnique; // Flips a given texture vertically (over a horizontal line)

global using FlattenVector3 = MonoBehaviourPublicVeXZVeVoVeVeVeVeVeVeUnique; // Takes in a Vector3 and returns a new one with y set to 0, doesn't normalize it

global using EatShitIdiot = MonoBehaviourPublicVoEaVoVoVoVoVoVoVoVoUnique; // Contains the method EatShit called when hacking is detected, which forces the client to leave the lobby they're currently in, deletes the Game Object the current instance of SteamManager is on, and shows the prompt in the menu "nice" "eat shit idiot"

global using ServerNameProfanityDetectorBase = ObjectPublicLi1StInStUnique; // Mac mono type name is Ⴃ\u109D\u109C\u109BႡႧ\u109A\u109CႢ႙႙. Guessing this is the profanity detection base class
global using IServerNameProfanityDetectorBase = InterfacePublicAbstractObInBoStRe1ChStRe1Unique;
global using ServerNameProfanityDetector = Object1PublicObObUnique; // Inherits from the above, seems to only ever be used to censor server list names and not chat?
global using ServerNameProfanityDetectorDetectAllProfanities = Object1PublicObObUnique.ObjectNPrivateSealedLi1StswUnique; // swearList
global using ServerNameProfanityDetectorDetectAllProfanities2 = Object1PublicObObUnique.ObjectNPrivateSealedStxUnique; // x
global using ServerNameProfanityDetectorContainsProfanity = Object1PublicObObUnique.ObjectNPrivateSealedStteUnique; // term
global using ServerNameProfanityDetectorAddMultiWordProfanities = Object1PublicObObUnique.ObjectNPrivateSealedStpoUnique; // postAllowListSentence
global using ServerNameProfanityWordList = ObjectPublicLi1StReIn1StUnique; // Name in the mac mono assembly is "\u109AႦ\u109EႧႦ\u109A\u109A\u109E\u109CႢ\u109F"
global using IServerNameProfanityWordListBase = InterfacePublicAbstractInRe1StVoBoStBoVoInUnique;

global using MaintainAngleToTarget = MonoBehaviourPublicTrTaVeQuUnique; // Uses Quaterion.FromToRotation to forever keep its initial angle making the same face always face its target





// === Remnants from Dani developing the game === //

global using DaniUnusedHexagonHeatBlockManager = MonoBehaviourPublicSipiGaLipi1InGaLi10; // Present in the unused map Color Crunch, it works similar to The Floor is Lava, but it generates a bunch of large cubes (those aren't Hexagons Dani!!!) rather than the smaller islands
global using DaniUnusedTntRunBlockManager = MonoBehaviourPublicSipiGaLipi1InGaLi12; // Present in the unused map Lava Run, it also generates a bunch of slightly smaller cubes that would presumably break as you run on them, like how TNT Run works in Minecraft

global using DaniUnusedMenuUiCreateLobbySpeedrun = MonoBehaviourPublicGamaTrInmanoGaprsrVo1; // There looks to have been a speedrunning mode planned for some time during development
global using DaniUnusedStation = MonoBehaviourPublicObtyUnique; // It seems Dani originally wanted there to be stations you could interact with to purchase things, namely weapons using the interactable money that was never used
global using DaniUnusedStationType = MonoBehaviourPublicObtyUnique.EnumNPublicSealedvaWe2vUnique;

global using DaniUnusedInteractableItemThrowable = MonoBehaviour2PublicGathObauTrgumuGaSiBoUnique; // This component is attached to the Grenade and PizzaSteve, though it seems to have some functionality in its methods it doesn't seem to call any of it
global using DaniUnusedInteractableItemDropped = MonoBehaviourPublicObRiSiupVeSiQuVeLiQuUnique; // This is only present when the item is not in anyone's inventory. It seems like it should allow the item to be hit (taking knockback) but it can't/doesn't, and that there's supposed to be some PhysicsObjectSnapshot system that it doesn't have functionality for
global using DaniUnusedInteractableMilk = MonoBehaviour2PublicUnique; // Seems to only be attached to the Milk item prefab, all of it's overridden methods throw the NotImplementedException exception
global using DaniUnusedInteractableMoney = MonoBehaviour1PublicInamUnique; // When picked up, it increments one of the integer fields (presumably called money) on the player's Client object used in LobbyManager by the integer amount field of this component, this was most likely currency for the stations Dani also didn't use
global using DaniUnusedInteractableAmmo = MonoBehaviour2PublicObamUnique; // It seems that there was originally going to be a way to reload using these ammo packs, but picking them up doesn't seem to reload any weapons, simply deleting the ammo, and all of it's overridden methods throw the NotImplementedException exception
global using DaniUnusedInteractableAmmoType = MonoBehaviour2PublicObamUnique.EnumNPublicSealedvaSmShRiSnEx6vUnique;

global using DaniTestGameModeAvailableMaps = MonoBehaviourPublicGagaUnique; // Present on the Islands and Sandy Islands maps, calls a method in this.gameMode (GameModeData) on Start() that picks a random compatible map for 8 players
global using DaniTestLobby = MonoBehaviourPublicBoUnique; // Present on serveral maps, assuming it would create a lobby and spawn Dani in any scene in the Unity Editor he had active, for quicker testing purposes
global using DaniTestDummySpawner = MonoBehaviourPublicVoStVoVoVoVoVoVoVoVo1; // Seems to not be on any Game Objects at all, but will spawn 3 dummy players with player numbers 1-3 (client ids 0-2) at 0 0 0 on top of each other, Mac mono type name is Ⴅ\u109DႤႤႢ႙Ⴁ\u109B\u109F\u109EႤ
global using DaniTestUngroupPlayerAndCamera = MonoBehaviourPublicVoStVoVoVoVoVoVoVoVo0; // Attached to the PlayerAndCamera Game Object in the Waiting room scene. It is disabled by default, but would loop through all children (those being Player and Camera) and set their parents to null, and then destroy its Game Object. Mac mono type is \u109BႥ\u109D\u109A\u109AႦႧႠႢ\u109BႢ
global using DaniTestMovingInteractable = MonoBehaviour1PublicGaobSimoVemoVeUnique; // This component isn't present anywhere, but I believe Dani used it to test interactables, guessing from the Debug.LogError message "interacted with move interact lol" when doing so, present in its AllInteract method
global using DaniTestRagdollButton = MonoBehaviourPublicGaraUnique; // Not entirely certain of this, but this component may have been used by Dani to make the ragdoll button spam bit in his first Crab Game video
global using DaniTestScreenshotKeyListener = MonoBehaviourPublicIEVocaIEUpVoIEVoIEVoUnique; // This may have been used by Dani so he could get clean screenshots, possibly for the map thumbnails
global using DaniTestScreenshotTaker = ObjectPublicTeReCoTeVoCoReStSiCoUnique;

global using DaniUnknownOnlinePlayerBaka = MonoBehaviourPublicObonUnique; // Present on the OnlinePlayer prefab with a single field/property pointing to the OnlinePlayer MonoBehaviour and a method called Baka that has no functionality





// === Unknown / Seemingly Unused / Skimmed Over Quickly === //

global using _UNKNOWN___MonoBehaviourPublicVoStVoVoVoVoVoVoVoVo2 = MonoBehaviourPublicVoStVoVoVoVoVoVoVoVo2; // Has no functionality besides an empty Start method, 18 garbage methods, and no fields/properties
global using _UNKNOWN___MonoBehaviourPublicVoStVoVoVoVoVoVoVoVo3 = MonoBehaviourPublicVoStVoVoVoVoVoVoVoVo3; // No functionality, empty Start method, 30 garbage methods, no fields/properties
global using _UNKNOWN___MonoBehaviourPublicVoStVoUpVoVoVoVoVoVoUnique = MonoBehaviourPublicVoStVoUpVoVoVoVoVoVoUnique; // No functionality, empty Start and Update methods, 31 garbage methods, and no fields/properties

global using _UNKNOWN___MonoBehaviourPublicVoUpVoStVoVoVoVoVoVo0 = MonoBehaviourPublicVoUpVoStVoVoVoVoVoVo0; // Sends the Debug.LogError $"trying to flood servers, steam: {CSteamID from SteamManager?}" on Start, and Update has no functionality
global using _UNKNOWN___MonoBehaviourPublicVoUpVoStVoVoVoVoVoVo1 = MonoBehaviourPublicVoUpVoStVoVoVoVoVoVo1;// Sends the Debug.LogError "Doing something..." on Start, and Update has no functionality

global using _UNKNOWN___MonoBehaviourPublicVo1 = MonoBehaviourPublicVo1; // Has literally no methods or fields
global using _UNKNOWN___MonoBehaviourPublicVo2 = MonoBehaviourPublicVo2; // Same
global using _UNKNOWN___MonoBehaviourPublicVo3 = MonoBehaviourPublicVo3; // Same
global using _UNKNOWN___MonoBehaviourPublicVo4 = MonoBehaviourPublicVo4; // SAME
global using _UNKNOWN___ObjectPublicVoUnique = ObjectPublicVoUnique; // Literally same

global using _UNKNOWN___ObjectPublicInObInInUnique = ObjectPublicInObInInUnique; // Very obscure what this could be for
global using _UNKNOWN___ObjectPublicInObInInUnique_ValueTypeNPrivateSealedInInInUnique = ObjectPublicInObInInUnique.ValueTypeNPrivateSealedInInInUnique;

global using _UNKNOWN___MonoBehaviourPublicGamabtGaLi1ObInmaStUnique = MonoBehaviourPublicGamabtGaLi1ObInmaStUnique; // Seems to be for a map selector button manager of some sort, but can't find any usage of it in the game?
global using _UNKNOWN___MonoBehaviourPublicTetiRaimUIwoUnique = MonoBehaviourPublicTetiRaimUIwoUnique;

global using _UNKNOWN___MonoBehaviourPublicGasmSicoBoUnique = MonoBehaviourPublicGasmSicoBoUnique; // Something that creates smokeFx when contacting Ground

global using _UNKNOWN___MonoBehaviourPublicVoUpVoVoVoVoVoVoVoVo0 = MonoBehaviourPublicVoUpVoVoVoVoVoVoVoVo0; // Used to make a transform always face the main camera

global using _UNKNOWN___MonoBehaviourPublicSiscUnique = MonoBehaviourPublicSiscUnique; // Putting this on a game object will make it scale to 5.5x over some time, then start flattening while continuing to scale horizontally until the y scale is less than 0.1, at which point the game object will be deleted

global using _UNKNOWN___MonoBehaviourPublicMefiUnique = MonoBehaviourPublicMefiUnique; // Draws a debug line between a transform and its mesh bounds center

global using _UNKNOWN___MonoBehaviourPublicGaroObspUnique = MonoBehaviourPublicGaroObspUnique; // Spawns 50 rocks(?) at random positions within a spawn zone

global using _UNKNOWN___MonoBehaviourPublicTrheUnique = MonoBehaviourPublicTrheUnique; // Used to make a head(?) constantly rotate towards the euler angles -4, 180, 0

global using _UNKNOWN___MonoBehaviourPublicGaotUnique = MonoBehaviourPublicGaotUnique; // Something that seems to link a game object to another. Only seems to be used by ScrollingGroundCollider, allowing both the colliding object and the one it's linked to to be deleted together

global using _UNKNOWN___MonoBehaviourPublicVoUpVoVoVoVoVoVoVoVo2 = MonoBehaviourPublicVoUpVoVoVoVoVoVoVoVo2; // Makes the transform face the player camera

global using _UNKNOWN___MonoBehaviourPublicVoUpVoVoVoVoVoVoVoVo4 = MonoBehaviourPublicVoUpVoVoVoVoVoVoVoVo4; // Makes the transform spin at 90 degrees a second

global using _UNKNOWN___MonoBehaviourPublicVeDiStVeUnique = MonoBehaviourPublicVeDiStVeUnique; // Makes a transform move in a constant direction from level load


global using _UNUSED___MonoBehaviourPublicVedeTrVetaUnique = MonoBehaviourPublicVedeTrVetaUnique; // Makes a Game Object strictly follow a target Transform

global using _UNUSED___InterfacePublicAbstractStUnique = InterfacePublicAbstractStUnique; // The interface is never inherited from, has a single method, and has no base functionality to conclude what it could have been for

global using _UNUSED___InterfacePublicAbstractVo1 = InterfacePublicAbstractVo1; // The interface is never inherited from, has a single method, and has no base functionality, but is used by the PlayerInput.NotFrozenInput method when interacting with the currently highlighted object

global using _UNUSED___MonoBehaviourPublicRemaheRecoSiRecoUnique = MonoBehaviourPublicRemaheRecoSiRecoUnique; // Doesn't seem to be used, but seems to have been used to scale a ui vertically by a percentage for a header and some content

global using _UNUSED___MonoBehaviourPublicMeVeInSicegrVeIngrUnique = MonoBehaviourPublicMeVeInSicegrVeIngrUnique; // Has something to do with a mesh being generated for itself, but doesn't appear to be used anywhere
global using _UNUSED___MonoBehaviourPublicSiquVeMequInVeUnique = MonoBehaviourPublicSiquVeMequInVeUnique; // Same
global using _UNUSED___MonoBehaviourPublicMeVeInUnique = MonoBehaviourPublicMeVeInUnique; // SAME
global using _UNUSED___MonoBehaviourPublicSiyVObinUnique = MonoBehaviourPublicSiyVObinUnique; // Used by the above type for its yValue field, for some reason?

global using _UNUSED___ObjectPublicVoLi1TRaLi1TInVoUnique = ObjectPublicVoLi1TRaLi1TInVoUnique; // A type with only static methods that randomizes the order of a given List's contents, though it doesn't seem to be used anywhere
global using _UNUSED___MonoBehaviourPublicVoLi1ByInBySpLi1InUnique = MonoBehaviourPublicVoLi1ByInBySpLi1InUnique; // A type with a single static method called SplitByteDateBySize that splits an array of bytes into several arrays of bytes with a given size in a List

global using _UNUSED___MonoBehaviourPrivateTrFoLoTrHaStHaAtTrTrUnique = MonoBehaviourPrivateTrFoLoTrHaStHaAtTrTrUnique; // Potentially for some kind of inverse kinematics? Not entirely sure

global using _UNUSED___MonoBehaviourPublicStObStBoObUnique = MonoBehaviourPublicStObStBoObUnique; // Has a LOT of functionality that just seamingly goes unused. Maybe was some centralized manager Dani used early on and swapped out for serveral less centralized components?
global using _UNUSED___MonoBehaviourPublicStObStBoObUnique_ObjectNPrivateCSStCSStUnique = MonoBehaviourPublicStObStBoObUnique.ObjectNPrivateCSStCSStUnique;
global using _UNUSED___MonoBehaviourPublicStObStBoObUnique_ObjectNPrivateAbstractUnique = MonoBehaviourPublicStObStBoObUnique.ObjectNPrivateAbstractUnique;
global using _UNUSED___MonoBehaviourPublicStObStBoObUnique_Object1NPrivateSealedUnique = MonoBehaviourPublicStObStBoObUnique.Object1NPrivateSealedUnique;
global using _UNUSED___MonoBehaviourPublicStObStBoObUnique_Object1NPrivateSealedIDisposableCa1LoLiOb1Unique = MonoBehaviourPublicStObStBoObUnique.Object1NPrivateSealedIDisposableCa1LoLiOb1Unique;
global using _UNUSED___MonoBehaviourPublicStObStBoObUnique_Object1NPrivateSealedObVeUnique = MonoBehaviourPublicStObStBoObUnique.Object1NPrivateSealedObVeUnique;
global using _UNUSED___MonoBehaviourPublicStObStBoObUnique_Object1NPrivateSealedObUnique = MonoBehaviourPublicStObStBoObUnique.Object1NPrivateSealedObUnique;
global using _UNUSED___MonoBehaviourPublicStObStBoObUnique_Object1NPrivateSealedObUnique_Object1NPrivateIDisposableCSCa1LoBoDaBoUnique = MonoBehaviourPublicStObStBoObUnique.Object1NPrivateSealedObUnique.Object1NPrivateIDisposableCSCa1LoBoDaBoUnique;
global using _UNUSED___MonoBehaviourPublicStObStBoObUnique_Object1NPrivateSealedObUnique_Object1NPrivateIDisposableCSTiCSDaStDaBoCaBo1Unique = MonoBehaviourPublicStObStBoObUnique.Object1NPrivateSealedObUnique.Object1NPrivateIDisposableCSTiCSDaStDaBoCaBo1Unique;
global using _UNUSED___MonoBehaviourPublicStObStBoObUnique_Object1NPrivateSealedIDisposableBoCa1LoObUnique = MonoBehaviourPublicStObStBoObUnique.Object1NPrivateSealedIDisposableBoCa1LoObUnique;
global using _UNUSED___MonoBehaviourPublicStObStBoObUnique_Object1NPrivateSealedIDisposableBoCSBoUnique = MonoBehaviourPublicStObStBoObUnique.Object1NPrivateSealedIDisposableBoCSBoUnique;
global using _UNUSED___MonoBehaviourPublicStObStBoObUnique_Object1NPrivateSealedBoObCSAsBoUnique = MonoBehaviourPublicStObStBoObUnique.Object1NPrivateSealedBoObCSAsBoUnique;
global using _UNUSED___MonoBehaviourPublicStObStBoObUnique_Object1NPrivateAbstractIDisposableCa1P2LoCa1CSStCSObUnique = MonoBehaviourPublicStObStBoObUnique.Object1NPrivateAbstractIDisposableCa1P2LoCa1CSStCSObUnique;
global using _UNUSED___MonoBehaviourPublicStObStBoObUnique_Object1NPrivateAbstractIDisposableCa1P2LoCa1CSStCSObUnique_ObjectNPrivateSealedObP2paUnique = MonoBehaviourPublicStObStBoObUnique.Object1NPrivateAbstractIDisposableCa1P2LoCa1CSStCSObUnique.ObjectNPrivateSealedObP2paUnique;
global using _UNUSED___MonoBehaviourPublicStObStBoObUnique_Object2NPrivateSealedVoCS0 = MonoBehaviourPublicStObStBoObUnique.Object2NPrivateSealedVoCS0;
global using _UNUSED___MonoBehaviourPublicStObStBoObUnique_Object2NPrivateSealedVoCS1 = MonoBehaviourPublicStObStBoObUnique.Object2NPrivateSealedVoCS1;