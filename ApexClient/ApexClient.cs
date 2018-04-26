using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using CitizenFX.Core.Native;

namespace ApexClient
{
    class ApexClient : BaseScript
    {
        public ApexClient()
        {
            EventHandlers["onClientMapStart"] += new Action(OnMapStart);
        }

        public void OnMapStart()
        {
            API.ShutdownLoadingScreen();
            API.DisplayRadar(false);
            API.DisplayHud(false);
            API.LoadMpDlcMaps();
            API.EnableMpDlcMaps(true);
            this.LoadIpls();
            TriggerServerEvent("requestApexAccount");
        }

        // Request unloaded IPLs
        // Converted to C# from https://forum.fivem.net/t/release-fix-holes-in-the-map/25240
        private void LoadIpls()
        {
            // Simeon: -47.16170 - 1115.3327 26.5
            API.RequestIpl("shr_int");

            // Trevor's Trailer (Trashed): 1985.48132, 3828.76757, 32.5
            API.RequestIpl("TrevorsMP");            // Needed?
            API.RequestIpl("TrevorsTrailer");       // Needed?
            API.RequestIpl("TrevorsTrailerTrash");  // Can also be "trevorstrailertidy" for clean trailer

            // Heist Jewel: -637.20159 -239.16250 38.1
            API.RequestIpl("post_hiest_unload");

            // Max Renda: -585.8247, -282.72, 35.45475
            API.RequestIpl("refit_unload");

            // Heist Union Depository: 2.69689322, -667.0166, 16.1306286
            API.RequestIpl("FINBANK");

            // Morgue: 239.75195, -1360.64965, 39.53437
            API.RequestIpl("coronertrash");
            API.RequestIpl("Coroner_Int_On");

            // Cluckin Bell: -146.3837, 6161.5, 30.2062
            API.RequestIpl("CS1_02_cf_onmission1");
            API.RequestIpl("CS1_02_cf_onmission2");
            API.RequestIpl("CS1_02_cf_onmission3");
            API.RequestIpl("CS1_02_cf_onmission4");

            // O'Neils (Grapeseed) Farm: 2447.9, 4973.4, 47.7
            API.RequestIpl("farm");
            API.RequestIpl("farmint");
            API.RequestIpl("farm_lod");
            API.RequestIpl("farm_props");
            API.RequestIpl("des_farmhouse");

            // FIB Lobby: 105.4557, -745.4835, 44.7548
            API.RemoveIpl("FIBlobbyfake");
            API.RequestIpl("FIBlobby");

            // Billboard: iFruit
            API.RequestIpl("FruitBB");
            API.RequestIpl("sc1_01_newbill");
            API.RequestIpl("hw1_02_newbill");
            API.RequestIpl("hw1_emissive_newbill");
            API.RequestIpl("sc1_14_newbill");
            API.RequestIpl("dt1_17_newbill");

            // Lester's factory: 716.84, -962.05, 31.59
            API.RequestIpl("id2_14_during_door");
            API.RequestIpl("id2_14_during1");

            // Life Invader lobby: -1047.9, -233.0, 39.0
            API.RequestIpl("facelobby");

            // Tunnels
            API.RequestIpl("v_tunnel_hole");

            // Carwash: 55.7, -1391.3, 30.5
            API.RequestIpl("Carwash_with_spinners");

            // Stadium "Fame or Shame": -248.49159240722656, -2010.509033203125, 34.57429885864258
            API.RequestIpl("sp1_10_real_interior");
            API.RequestIpl("sp1_10_real_interior_lod");

            // House in Banham Canyon: -3086.428, 339.2523, 6.3717
            API.RequestIpl("ch1_02_open");

            // Garage in La Mesa(autoshop): 970.27453, -1826.56982, 31.11477
            API.RequestIpl("bkr_bi_id1_23_door");

            // Hill Valley church - Grave: -282.46380000, 2835.84500000, 55.91446000
            API.RequestIpl("lr_cs6_08_grave_closed");

            // Lost's trailer park: 49.49379000, 3744.47200000, 46.38629000
            API.RequestIpl("methtrailer_grp1");

            // Lost safehouse: 984.1552, -95.3662, 74.50
            API.RequestIpl("bkr_bi_hw1_13_int");

            // Raton Canyon river: -1652.83, 4445.28, 2.52
            API.RequestIpl("CanyonRvrShallow");

            // Zancudo Gates (GTA:O): -1600.30100000, 2806.73100000, 18.79683000
            API.RequestIpl("CS3_07_MPGates");

            // Pillbox Hospital
            API.RequestIpl("rc12b_default");

            // Josh's house: -1117.1632080078, 303.090698, 66.52217
            API.RequestIpl("bh1_47_joshhse_unburnt");
            API.RequestIpl("bh1_47_joshhse_unburnt_lod");

            // Zancudo River: 86.815, 3191.649, 30.463      (Requires streamed content)
            // Cassidy Creek: -425.677, 4433.404, 27.3253   (Requires streamed content)

            // Graffiti
            API.RequestIpl("ch3_rd2_bishopschickengraffiti");   // 1861.28, 2402.11, 58.53
            API.RequestIpl("cs5_04_mazebillboardgraffiti");     // 2697.32, 3162.18, 58.1
            API.RequestIpl("cs5_roads_ronoilgraffiti");         // 2119.12, 3058.21, 53.25

            // Bunkers - Exterior
            API.RequestIpl("gr_case0_bunkerclosed");
            API.RequestIpl("gr_case1_bunkerclosed");
            API.RequestIpl("gr_case2_bunkerclosed");
            API.RequestIpl("gr_case3_bunkerclosed");
            API.RequestIpl("gr_case4_bunkerclosed");
            API.RequestIpl("gr_case5_bunkerclosed");
            API.RequestIpl("gr_case6_bunkerclosed");
            API.RequestIpl("gr_case7_bunkerclosed");
            API.RequestIpl("gr_case9_bunkerclosed");
            API.RequestIpl("gr_case10_bunkerclosed");
            API.RequestIpl("gr_case11_bunkerclosed");

            // Bunkers - Interior: 892.6384, -3245.8664, -98.2645
            API.RequestIpl("gr_entrance_placement");
            API.RequestIpl("gr_grdlc_interior_placement");
            API.RequestIpl("gr_grdlc_interior_placement_interior_0_grdlc_int_01_milo_");
            API.RequestIpl("gr_grdlc_interior_placement_interior_1_grdlc_int_02_milo_");
        
            // Biker
            API.RequestIpl("bkr_biker_interior_placement_interior_0_biker_dlc_int_01_milo");
            API.RequestIpl("bkr_biker_interior_placement_interior_1_biker_dlc_int_02_milo");
            API.RequestIpl("bkr_biker_interior_placement_interior_2_biker_dlc_int_ware01_milo");
            API.RequestIpl("bkr_biker_interior_placement_interior_3_biker_dlc_int_ware02_milo");
            API.RequestIpl("bkr_biker_interior_placement_interior_4_biker_dlc_int_ware03_milo");
            API.RequestIpl("bkr_biker_interior_placement_interior_5_biker_dlc_int_ware04_milo");
            API.RequestIpl("bkr_biker_interior_placement_interior_6_biker_dlc_int_ware05_milo");
            API.RequestIpl("ex_exec_warehouse_placement_interior_1_int_warehouse_s_dlc_milo");
            API.RequestIpl("ex_exec_warehouse_placement_interior_0_int_warehouse_m_dlc_milo");
            API.RequestIpl("ex_exec_warehouse_placement_interior_2_int_warehouse_l_dlc_milo");

            // Import/Export
            API.RequestIpl("imp_dt1_02_modgarage");
            API.RequestIpl("imp_dt1_02_cargarage_a");
            API.RequestIpl("imp_dt1_02_cargarage_b");
            API.RequestIpl("imp_dt1_02_cargarage_c");

            API.RequestIpl("imp_dt1_11_modgarage");
            API.RequestIpl("imp_dt1_11_cargarage_a");
            API.RequestIpl("imp_dt1_11_cargarage_b");
            API.RequestIpl("imp_dt1_11_cargarage_c");

            API.RequestIpl("imp_sm_13_modgarage");
            API.RequestIpl("imp_sm_13_cargarage_a");
            API.RequestIpl("imp_sm_13_cargarage_b");
            API.RequestIpl("imp_sm_13_cargarage_c");

            API.RequestIpl("imp_sm_15_modgarage");
            API.RequestIpl("imp_sm_15_cargarage_a");
            API.RequestIpl("imp_sm_15_cargarage_b");
            API.RequestIpl("imp_sm_15_cargarage_c");

            API.RequestIpl("imp_impexp_interior_placement");
            API.RequestIpl("imp_impexp_interior_placement_interior_0_impexp_int_01_milo_");
            API.RequestIpl("imp_impexp_interior_placement_interior_3_impexp_int_02_milo_");
            API.RequestIpl("imp_impexp_interior_placement_interior_1_impexp_intwaremed_milo_");
            API.RequestIpl("imp_impexp_interior_placement_interior_2_imptexp_mod_int_01_milo_");

            // Bridge Train Normal
            API.RequestIpl("canyonriver01");
            API.RequestIpl("railing_start");
        }
    }
}
