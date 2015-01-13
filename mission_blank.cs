version=11;
class Mission
{
	addOns[]=
	{
		"chernarus",
		"ca_modules_animals",
		"dayz_code",
		"dayz_weapons",
		"dayz_equip",
		"dayz_vehicles",
		"cacharacters_pmc",
		"ca_modules_functions",
		"warfarebuildings",
		"camisc3",
		"camisc_e",
		"casigns_e",
		"CAMisc",
		"ind_tank",
		"castructures_e_misc_misc_interier",
		"camp_armory_misc_loudspeakers",
		"castructures_e_misc_misc_well",
		"caweapons_ammoboxes",
		"CAWater",
		"cawater2_fregata",
		"cawater2_destroyer",
		"caweapons_e_ammoboxes",
		"castructures_e_misc_misc_market",
		"camisc_e_wf",
		"CABuildings",
		"camp_armory_misc_red_light",
		"cadata",
		"castructures_e_misc_misc_construction",
		"camp_armory_misc_concrete_wall",
		"cabuildings2_misc_cargo",
		"castructures_e_wall",
		"camp_armory_misc",
		"camp_armory_misc_entrance_gate",
		"cacharacters_e"
	};
	addOnsAuto[]=
	{
		"dayz_weapons",
		"ca_modules_functions",
		"cacharacters_e",
		"camisc3",
		"camisc_e",
		"CAMisc",
		"ind_tank",
		"castructures_e_misc_misc_interier",
		"camp_armory_misc_loudspeakers",
		"castructures_e_misc_misc_well",
		"casigns_e",
		"CABuildings",
		"warfarebuildings",
		"camp_armory_misc_red_light",
		"dayz_equip",
		"cadata",
		"camisc_e_wf",
		"castructures_e_misc_misc_construction",
		"camp_armory_misc_concrete_wall",
		"castructures_e_misc_misc_market",
		"cabuildings2_misc_cargo",
		"cawater2_fregata",
		"cawater2_destroyer",
		"castructures_e_wall",
		"camp_armory_misc",
		"camp_armory_misc_entrance_gate",
		"chernarus"
	};
	randomSeed=11171215;
	class Intel
	{
		briefingName="DayZ Chernarus";
		briefingDescription="DayZ";
		startWeather=0.067362607;
		forecastWeather=0.52341133;
		year=2008;
		month=10;
		day=1;
		hour=12;
	};
	class Groups
	{
		items=1;
		class Item0
		{
			side="WEST";
			class Vehicles
			{
				items=2;
				class Item0
				{
					position[]={-18709.713,379.10086,25923.943};
					azimut=-17.0839;
					id=11;
					side="WEST";
					vehicle="Survivor1_DZ";
					player="PLAY CDG";
					skill=0.60000002;
					init="this enableSimulation false;this allowDammage false;this disableAI 'FSM';this disableAI 'ANIM';this disableAI 'MOVE';";
				};
				class Item1
				{
					position[]={-18621.865,368.67456,25857.564};
					azimut=-17.0839;
					id=0;
					side="WEST";
					vehicle="Survivor1_DZ";
					player="PLAYER COMMANDER";
					leader=1;
					rank="SERGEANT";
					skill=0.60000002;
					init="this enableSimulation false;this allowDammage false;this disableAI 'FSM';this disableAI 'ANIM';this disableAI 'MOVE';";
				};
			};
		};
	};
	class Markers
	{
		items=3;
		class Item0
		{
			position[]={7839.6055,381.33774,8414.7324};
			name="center";
			type="Empty";
		};
		class Item1
		{
			position[]={-18697.58,379.53012,25815.256};
			name="respawn_west";
			type="Empty";
		};
		class Item2
		{
			position[]={4932.3345,4932.39950246,1989.1094};
			name="spawn0";
			type="Empty";
            init="[this, 600] exec 'ca\air2\halo\data\Scripts\HALO_init.sqs';";
		};
	};
};
class Intro
{
	addOns[]=
	{
		"chernarus"
	};
	addOnsAuto[]=
	{
		"chernarus"
	};
	randomSeed=6913869;
	class Intel
	{
		startWeather=0.25;
		forecastWeather=0.25;
		year=2008;
		month=10;
		day=11;
		hour=9;
		minute=20;
	};
};
class OutroWin
{
	addOns[]=
	{
		"chernarus"
	};
	addOnsAuto[]=
	{
		"chernarus"
	};
	randomSeed=4081731;
	class Intel
	{
		startWeather=0.25;
		forecastWeather=0.25;
		year=2008;
		month=10;
		day=11;
		hour=9;
		minute=20;
	};
};
class OutroLoose
{
	addOns[]=
	{
		"chernarus"
	};
	addOnsAuto[]=
	{
		"chernarus"
	};
	randomSeed=4975929;
	class Intel
	{
		startWeather=0.25;
		forecastWeather=0.25;
		year=2008;
		month=10;
		day=11;
		hour=9;
		minute=20;
	};
};
