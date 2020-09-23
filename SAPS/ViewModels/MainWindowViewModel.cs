using Prism.Commands;
using Prism.Mvvm;
using System;

namespace SAPS.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";

        public double ahl = 0;
        public double currentAhl = 0;


        public double ahc = 0;
        public double currentAhc = 0;
        public double designCurrent = 0;
        public double deratedDesignCurrent = 0;
        public double modulesInParallel = 0;
        public double modulesInSeries = 0;
        public double modulesInTotal = 0;
        public double correctedBattery = 0;
        public double batteryInParallel = 0;
        public double batteryInSeries = 0;
        public double totalNumberOfBattery = 0;
        public double arrayShortCircuitCurrent = 0;
        public double designControllerCapacity = 0;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _noOfAppliance;
        public string NoOfAppliance
        {
            get { return _noOfAppliance; }
            set
            {
                SetProperty(ref _noOfAppliance, value);
                AHLCommand.RaiseCanExecuteChanged();
            }
        }

        private string _powerRating;
        public string PowerRating
        {
            get { return _powerRating; }
            set
            {
                SetProperty(ref _powerRating, value);
                AHLCommand.RaiseCanExecuteChanged();
            }
        }

        private string _dailyDuty;
        public string DailyDuty
        {
            get { return _dailyDuty; }
            set
            {
                SetProperty(ref _dailyDuty, value);
                AHLCommand.RaiseCanExecuteChanged();
            }
        }

        private string _weeklyDailyCycle;
        public string WeeklyDailyCycle
        {
            get { return _weeklyDailyCycle; }
            set
            {
                SetProperty(ref _weeklyDailyCycle, value);
                AHLCommand.RaiseCanExecuteChanged();
            }
        }

        private string _voltageSystemNominal;
        public string VoltageSystemNominal
        {
            get { return _voltageSystemNominal; }
            set
            {
                SetProperty(ref _voltageSystemNominal, value);
                AHLCommand.RaiseCanExecuteChanged();
            }
        }

        private string _efficiency;
        public string Efficiency
        {
            get { return _efficiency; }
            set
            {
                SetProperty(ref _efficiency, value);
                AHLCommand.RaiseCanExecuteChanged();
            }
        }

        private string _ahl;
        public string AHL
        {
            get { return _ahl; }
            set
            {
                SetProperty(ref _ahl, value);
                ResetAmpCommand.RaiseCanExecuteChanged();
                TotalAHLCommand.RaiseCanExecuteChanged();

            }
        }

        private string _ahlTotal;
        public string TotalAHL
        {
            get { return _ahlTotal; }
            set
            {
                SetProperty(ref _ahlTotal, value);
            }
        }

        private string _parallelModule;
        public string ParallelModule
        {
            get { return _parallelModule; }
            set
            {
                SetProperty(ref _parallelModule, value);
                ResetDeratedeSignCurrent.RaiseCanExecuteChanged();
                TotalNumberOfModulesCommand.RaiseCanExecuteChanged();


            }
        }

        private string _wireEfficiency;
        public string WireEfficiency
        {
            get { return _wireEfficiency; }
            set
            {
                SetProperty(ref _wireEfficiency, value);
                AHCCommand.RaiseCanExecuteChanged();
            }
        }

        private string _batteryEfficiency;
        public string BatteryEfficiency
        {
            get { return _batteryEfficiency; }
            set
            {
                SetProperty(ref _batteryEfficiency, value);
                AHCCommand.RaiseCanExecuteChanged();
            }
        }

        private string _peakSunHours;
        public string PeakSunHours
        {
            get { return _peakSunHours; }
            set
            {
                SetProperty(ref _peakSunHours, value);
                AHCCommand.RaiseCanExecuteChanged();
            }
        }

        private string _ahc;
        public string AHC
        {
            get { return _ahc; }
            set
            {
                SetProperty(ref _ahc, value);
                AHCCommand.RaiseCanExecuteChanged();
                DesignCurrentCommand.RaiseCanExecuteChanged();
                ResetAHCCommand.RaiseCanExecuteChanged();
                CorrectedBatteryCapacityCommand.RaiseCanExecuteChanged();

            }
        }

        private string _designCurrent;
        public string DesignCurrent
        {
            get { return _designCurrent; }
            set
            {
                SetProperty(ref _designCurrent, value);
                ResetAHCCommand.RaiseCanExecuteChanged();

            }
        }

        private string _moduleRate;
        public string ModuleRate
        {
            get { return _moduleRate; }
            set
            {
                SetProperty(ref _moduleRate, value);
                DeratedDesignCommand.RaiseCanExecuteChanged();
            }
        }

        private string _manufactureRatedOutput;
        public string ManufactureRatedOutput
        {
            get { return _manufactureRatedOutput; }
            set
            {
                SetProperty(ref _manufactureRatedOutput, value);
                DeratedDesignCommand.RaiseCanExecuteChanged();

            }
        }

        private string _deratedDesign;
        public string DeratedDesign
        {
            get { return _deratedDesign; }
            set
            {
                SetProperty(ref _deratedDesign, value);
                ResetDeratedeSignCurrent.RaiseCanExecuteChanged();
            }
        }

        private string _nominalSystemVoltage;
        public string NominalSystemVoltage
        {
            get { return _nominalSystemVoltage; }
            set
            {
                SetProperty(ref _nominalSystemVoltage, value);
                SeriesModuleCommand.RaiseCanExecuteChanged();
            }
        }

        private string _moduleNominalVoltage;
        public string ModuleNominalVoltage
        {
            get { return _moduleNominalVoltage; }
            set
            {
                SetProperty(ref _moduleNominalVoltage, value);
                SeriesModuleCommand.RaiseCanExecuteChanged();

            }
        }

        private string _modulesInSeries;
        public string ModulesInSeries
        {
            get { return _modulesInSeries; }
            set
            {
                SetProperty(ref _modulesInSeries, value);
                TotalNumberOfModulesCommand.RaiseCanExecuteChanged();
                ResetSAndTModuleCommand.RaiseCanExecuteChanged();


            }
        }
        private string _totalNumberOfModules;
        public string TotalNumberOfModules
        {
            get { return _totalNumberOfModules; }
            set
            {
                SetProperty(ref _totalNumberOfModules, value);
                ResetSAndTModuleCommand.RaiseCanExecuteChanged();

            }
        }

        private string _storageDays;
        public string StorageDays
        {
            get { return _storageDays; }
            set
            {
                SetProperty(ref _storageDays, value);
                CorrectedBatteryCapacityCommand.RaiseCanExecuteChanged();


            }
        }

        private string _maxDepthDischarge;
        public string MaxDepthDischarge
        {
            get { return _maxDepthDischarge; }
            set
            {
                SetProperty(ref _maxDepthDischarge, value);
                CorrectedBatteryCapacityCommand.RaiseCanExecuteChanged();


            }
        }
        private string _tempFactor;
        public string TempFactor
        {
            get { return _tempFactor; }
            set
            {
                SetProperty(ref _tempFactor, value);
                CorrectedBatteryCapacityCommand.RaiseCanExecuteChanged();

            }
        }
        private string _batteryRating;
        public string BatteryRating
        {
            get { return _batteryRating; }
            set
            {
                SetProperty(ref _batteryRating, value);
                BatteryInParallelCommand.RaiseCanExecuteChanged();

            }
        }


        private string _batteryInParallel;
        public string BatteryInParallel
        {
            get { return _batteryInParallel; }
            set
            {
                SetProperty(ref _batteryInParallel, value);
                TotalNumberOfBatteryCommand.RaiseCanExecuteChanged();
                ResetBatterySizing.RaiseCanExecuteChanged();



            }
        }
        private string _batteryInSeries;
        public string BatteryInSeries
        {
            get { return _batteryInSeries; }
            set
            {
                SetProperty(ref _batteryInSeries, value);
                TotalNumberOfBatteryCommand.RaiseCanExecuteChanged();
                ResetBatterySizing.RaiseCanExecuteChanged();


            }
        }

        private string _batteryNominalVoltage;
        public string BatteryNominalVoltage
        {
            get { return _batteryNominalVoltage; }
            set
            {
                SetProperty(ref _batteryNominalVoltage, value);
                BatteryInSeriesCommand.RaiseCanExecuteChanged();
                ResetBatterySizing.RaiseCanExecuteChanged();


            }
        }

        private string _totalNumberOfBattery;
        public string TotalNumberOfBattery
        {
            get { return _totalNumberOfBattery; }
            set
            {
                SetProperty(ref _totalNumberOfBattery, value);
                ResetBatterySizing.RaiseCanExecuteChanged();

            }
        }
        private string _moduleShortCircuitCurrent;
        public string ModuleShortCircuitCurrent
        {
            get { return _moduleShortCircuitCurrent; }
            set
            {
                SetProperty(ref _moduleShortCircuitCurrent, value);
                ArrayShortCircuitCurrentCommand.RaiseCanExecuteChanged();
            }
        }
        private string _arrayShortCircuitCurrent;
        public string ArrayShortCircuitCurrent
        {
            get { return _arrayShortCircuitCurrent; }
            set
            {
                SetProperty(ref _arrayShortCircuitCurrent, value);
                DesignControllerCapacityCommand.RaiseCanExecuteChanged();
            }
        }
        private string _designControllerCapacity;
        public string DesignControllerCapacity
        {
            get { return _designControllerCapacity; }
            set
            {
                SetProperty(ref _designControllerCapacity, value);
            }
        }

        public DelegateCommand ResetAmpCommand { get; private set; }
        public DelegateCommand AHLCommand { get; private set; }
        public DelegateCommand TotalAHLCommand { get; private set; }
        public DelegateCommand AHCCommand { get; private set; }
        public DelegateCommand DesignCurrentCommand { get; private set; }
        public DelegateCommand DeratedDesignCommand { get; private set; }
        public DelegateCommand ResetAHCCommand { get; private set; }
        public DelegateCommand ResetDeratedeSignCurrent { get; private set; }
        public DelegateCommand SeriesModuleCommand { get; private set; }
        public DelegateCommand TotalNumberOfModulesCommand { get; private set; }
        public DelegateCommand ResetSAndTModuleCommand { get; private set; }
        public DelegateCommand CorrectedBatteryCapacityCommand { get; private set; }
        public DelegateCommand BatteryInParallelCommand { get; private set; }
        public DelegateCommand BatteryInSeriesCommand { get; private set; }
        public DelegateCommand TotalNumberOfBatteryCommand { get; private set; }
        public DelegateCommand ResetBatterySizing { get; private set; }
        public DelegateCommand ArrayShortCircuitCurrentCommand { get; private set; }
        public DelegateCommand DesignControllerCapacityCommand { get; private set; }
        public MainWindowViewModel()
        {
            AHLCommand = new DelegateCommand(ExecuteAhl, CanExecuteAhl);
            AHCCommand = new DelegateCommand(ExecuteAhc, CanExecuteAhc);
            ResetAmpCommand = new DelegateCommand(ExecuteResetAmp, CanExecuteResetAmp);
            ResetAHCCommand = new DelegateCommand(ExecuteResetAhc, CanExecuteResetAhc);
            ResetDeratedeSignCurrent = new DelegateCommand(ExecuteResetDeratedDesign, CanExecuteResetDeratedDesign);
            TotalAHLCommand = new DelegateCommand(ExecuteTotalAmp, CanExecuteTotalAmp);
            DesignCurrentCommand = new DelegateCommand(ExecuteDesignCurrent, CanExecuteDesignCurrent);
            DeratedDesignCommand = new DelegateCommand(ExecuteDeratedDesign, CanExecuteDeratedDesign);
            SeriesModuleCommand = new DelegateCommand(ExecuteSeriesModule, CanExecuteSeriesModule);
            TotalNumberOfModulesCommand = new DelegateCommand(ExecuteTotalNumberOfModule, CanExecuteTotalNumberOfModule);
            ResetSAndTModuleCommand = new DelegateCommand(ExecuteTotalResetSandTModule, CanExecuteResetSandTModule);
            CorrectedBatteryCapacityCommand = new DelegateCommand(ExecuteCorrectedBatteryCapacity, CanExecuteCorrectedBatteryCapacity);
            BatteryInParallelCommand = new DelegateCommand(ExecuteBatteryInParallel, CanExecuteBatteryInParallel);
            BatteryInSeriesCommand = new DelegateCommand(ExecuteBatteryInSeries, CanExecuteBatteryInSeries);
            TotalNumberOfBatteryCommand = new DelegateCommand(ExecuteTotalNumberOfBattery, CanExecuteTotalNumberOfBattery);
            ResetBatterySizing = new DelegateCommand(ExecuteResetBatterySizing, CanExecuteResetBatterySizing);
            ArrayShortCircuitCurrentCommand = new DelegateCommand(ExecuteArrayShortCircuitCurrent, CanExecuteArrayShortCircuitCurrent);
            DesignControllerCapacityCommand = new DelegateCommand(ExecuteDesignControllerCapacity, CanExecuteDesignControllerCapacity);
        }

        private bool CanExecuteDesignControllerCapacity()
        {
            if (arrayShortCircuitCurrent != 0)
            {

                return true;
            }

            return false;
        }

        private void ExecuteDesignControllerCapacity()
        {
            designControllerCapacity = 1.25 * arrayShortCircuitCurrent;

            DesignControllerCapacity = Convert.ToString(Math.Round(designControllerCapacity, 2));
        }

        private bool CanExecuteArrayShortCircuitCurrent()
        {
            bool canExecute = false;
            if (string.IsNullOrWhiteSpace(ModuleShortCircuitCurrent)

                )
            {

                canExecute = false;

            }
            else
            {
                if (
                    !checkModuleShortCircuitInput()
                    )
                {

                    canExecute = false;
                }
                else
                {
                    canExecute = true;
                }
            }

            return canExecute;
        }

        private void ExecuteArrayShortCircuitCurrent()
        {
            arrayShortCircuitCurrent = Convert.ToDouble(ModuleShortCircuitCurrent) / modulesInParallel;

            ArrayShortCircuitCurrent = Convert.ToString(Math.Round(arrayShortCircuitCurrent, 2));

        }

        private bool CanExecuteResetBatterySizing()
        {
            if (batteryInParallel != 0 && batteryInSeries != 0 && totalNumberOfBattery != 0)
            {

                return true;
            }

            return false;
        }

        private void ExecuteResetBatterySizing()
        {
            BatteryRating = null;
            BatteryNominalVoltage = null;
            BatteryInParallel = null;
            TotalNumberOfBattery = null;
            StorageDays = null;
            MaxDepthDischarge = null;
            TempFactor = null;
            batteryInSeries = 0;
            batteryInParallel = 0;
            totalNumberOfBattery = 0;
            correctedBattery = 0;

        }

        private bool CanExecuteTotalNumberOfBattery()
        {
            bool canExecute = false;
            if (batteryInSeries == 0 && batteryInParallel == 0
                )
            {

                canExecute = false;

            }
            else
            {
                canExecute = true;

            }

            return canExecute;
        }

        private void ExecuteTotalNumberOfBattery()
        {
            totalNumberOfBattery = batteryInParallel * batteryInSeries;
            TotalNumberOfBattery = Convert.ToString(Math.Round(totalNumberOfBattery, 2));
        }

        private bool CanExecuteBatteryInSeries()
        {
            bool canExecute = false;
            if (string.IsNullOrWhiteSpace(BatteryNominalVoltage) && string.IsNullOrWhiteSpace(BatteryNominalVoltage)

                )
            {

                canExecute = false;

            }
            else
            {
                if (
                    !checkBatteryNominalVoltageInput()
                    )
                {

                    canExecute = false;
                }
                else
                {
                    canExecute = true;
                }
            }

            return canExecute;
        }

        private void ExecuteBatteryInSeries()
        {
            batteryInSeries = Convert.ToDouble(NominalSystemVoltage) / Convert.ToDouble(BatteryNominalVoltage);
            BatteryInSeries = Convert.ToString(Math.Round(batteryInSeries, 2));

        }

        private bool CanExecuteBatteryInParallel()
        {
            bool canExecute = false;
            if (string.IsNullOrWhiteSpace(BatteryRating)

                )
            {

                canExecute = false;

            }
            else
            {
                if (
                    !checkBatteryRatingInput()
                    )
                {

                    canExecute = false;
                }
                else
                {
                    canExecute = true;
                }
            }

            return canExecute;
        }

        private void ExecuteBatteryInParallel()
        {
            batteryInParallel = correctedBattery / Convert.ToDouble(BatteryRating);
            BatteryInParallel = Convert.ToString(Math.Round(batteryInParallel, 2));
        }

        private bool CanExecuteCorrectedBatteryCapacity()
        {
            bool canExecute = false;
            if (string.IsNullOrWhiteSpace(StorageDays) &&
                string.IsNullOrWhiteSpace(MaxDepthDischarge) &&
                string.IsNullOrWhiteSpace(TempFactor)
                )
            {

                canExecute = false;

            }
            else
            {
                if (
                    !checkCorrectedBatteryInput()
                    )
                {

                    canExecute = false;
                }
                else
                {
                    canExecute = true;
                }
            }

            return canExecute;
        }


        //used to perform calculation of corrected battery
        private void ExecuteCorrectedBatteryCapacity()
        {

            /*
             from formular 

            BC = (AHc × SD)/ (Dmax × Tf )   


             AHC = corrected ampere hour load.                             
             SD = days of storage 
             Dmax = maximum depth discharge.
             Tf = temperature correction factor 
             */
            correctedBattery = (ahc * Convert.ToDouble(StorageDays)) / (Convert.ToDouble(MaxDepthDischarge) * Convert.ToDouble(TempFactor));
        }

        private bool CanExecuteResetSandTModule()
        {
            if (modulesInTotal != 0 && modulesInSeries != 0)
            {

                return true;
            }

            return false;
        }

        private void ExecuteTotalResetSandTModule()
        {
            NominalSystemVoltage = null;
            ModuleNominalVoltage = null;
            ModulesInSeries = null;
            TotalNumberOfModules = null;

            modulesInTotal = 0;
            modulesInSeries = 0;
        }

        private bool CanExecuteTotalNumberOfModule()
        {
            if (modulesInSeries != 0 && modulesInParallel != 0)
            {

                return true;
            }

            return false;
        }

        private void ExecuteTotalNumberOfModule()
        {

            modulesInTotal = modulesInSeries * modulesInParallel;

            TotalNumberOfModules = Convert.ToString(Math.Round(modulesInTotal, 2));
        }

        private bool CanExecuteSeriesModule()
        {
            bool canExecute = false;
            if (string.IsNullOrWhiteSpace(ModuleNominalVoltage) &&
                string.IsNullOrWhiteSpace(NominalSystemVoltage)
                )
            {

                canExecute = false;

            }
            else
            {
                if (
                    !checkSeriesModuleInput()
                    )
                {

                    canExecute = false;
                }
                else
                {
                    canExecute = true;
                }
            }

            return canExecute;
        }

        private void ExecuteSeriesModule()
        {
            modulesInSeries = Convert.ToDouble(NominalSystemVoltage) / Convert.ToDouble(ModuleNominalVoltage);

            ModulesInSeries = Convert.ToString(Math.Round(modulesInSeries, 2));
        }

        private bool CanExecuteResetDeratedDesign()
        {
            if (deratedDesignCurrent != 0 || modulesInParallel != 0)
            {

                return true;
            }

            return false;
        }

        private void ExecuteResetDeratedDesign()
        {
            ModuleRate = null;
            ManufactureRatedOutput = null;
            deratedDesignCurrent = 0;
            modulesInParallel = 0;
            ParallelModule = null;
            DeratedDesign = null;
        }

        private void ExecuteDeratedDesign()
        {
            deratedDesignCurrent = designCurrent / Convert.ToDouble(ModuleRate);
            modulesInParallel = deratedDesignCurrent / Convert.ToDouble(ManufactureRatedOutput);

            DeratedDesign = Convert.ToString(Math.Round(deratedDesignCurrent, 2));
            ParallelModule = Convert.ToString(Math.Round(modulesInParallel, 2));
        }

        private bool CanExecuteDeratedDesign()
        {
            bool canExecute = false;
            if (string.IsNullOrWhiteSpace(ModuleRate) &&
                string.IsNullOrWhiteSpace(ManufactureRatedOutput)
                )
            {

                canExecute = false;

            }
            else
            {
                if (
                    !checkDeratedDesignInput()
                    )
                {

                    canExecute = false;
                }
                else
                {
                    canExecute = true;
                }
            }

            return canExecute;
        }

        private bool CanExecuteResetAhc()
        {
            if (ahc != 0)
            {

                return true;
            }

            return false;
        }

        private void ExecuteResetAhc()
        {
            WireEfficiency = null;
            BatteryEfficiency = null;
            PeakSunHours = null;
            designCurrent = 0;
            DesignCurrent = null;
            ahc = 0;
            AHC = null;

        }

        private bool CanExecuteDesignCurrent()
        {
            bool canExecute = false;
            if (string.IsNullOrWhiteSpace(AHC))
            {

                canExecute = false;

            }
            else
            {

                canExecute = true;
            }

            return canExecute;
        }

        private void ExecuteDesignCurrent()
        {

            designCurrent = ahc / Convert.ToDouble(PeakSunHours);

            DesignCurrent = Convert.ToString(Math.Round(designCurrent, 2));
        }

        private bool CanExecuteAhc()
        {
            bool canExecute = false;
            if (string.IsNullOrWhiteSpace(WireEfficiency) &&
                string.IsNullOrWhiteSpace(BatteryEfficiency) &&
                string.IsNullOrWhiteSpace(PeakSunHours)
                )
            {

                canExecute = false;

            }
            else
            {
                if (
                    !checkAhcInput()
                    )
                {

                    canExecute = false;
                }
                else
                {
                    canExecute = true;
                }
            }

            return canExecute;
        }

        private void ExecuteAhc()
        {

            if (
                    !double.TryParse(WireEfficiency, out double wireEfficiency) ||
                    !double.TryParse(BatteryEfficiency, out double batteryEfficiency) ||
                    !double.TryParse(PeakSunHours, out double peakSunHours)
                    )
            {

            }
            else
            {
                double totalAhc = ahl / (wireEfficiency * batteryEfficiency);
                ahc = ahc + totalAhc;
                currentAhc = totalAhc;

            }
            AHC = Convert.ToString(Math.Round(currentAhc, 2));
        }

        private bool CanExecuteTotalAmp()
        {
            if (ahl != 0)
            {
                return true;
            }

            return false;
        }

        private void ExecuteTotalAmp()
        {
            TotalAHL = Convert.ToString(Math.Round(ahl, 2));
        }

        private bool CanExecuteResetAmp()
        {
            if (ahl != 0)
            {

                return true;
            }

            return false;
        }

        private void ExecuteResetAmp()
        {
            NoOfAppliance = null;
            PowerRating = null;
            DailyDuty = null;
            WeeklyDailyCycle = null;
            VoltageSystemNominal = null;
            Efficiency = null;
            ahl = 0;
            AHL = null;
        }

        private bool CanExecuteAhl()
        {
            bool canExecute = false;
            if (
                string.IsNullOrWhiteSpace(PowerRating) &&
                string.IsNullOrWhiteSpace(DailyDuty) &&
                string.IsNullOrWhiteSpace(WeeklyDailyCycle) &&
                string.IsNullOrWhiteSpace(VoltageSystemNominal) &&
                string.IsNullOrWhiteSpace(Efficiency))
            {

                canExecute = false;

            }
            else
            {
                if (
                    !checkAhlInput()
                    )
                {

                    canExecute = false;
                }
                else
                {
                    canExecute = true;
                }
            }

            return canExecute;
        }

        private void ExecuteAhl()
        {
            if (
                    !double.TryParse(PowerRating, out double powerRating) ||
                    !double.TryParse(DailyDuty, out double dailyDuty) ||
                    !double.TryParse(WeeklyDailyCycle, out double weeklyDailyCycle) ||
                    !double.TryParse(VoltageSystemNominal, out double voltageSystemNominal) ||
                    !double.TryParse(Efficiency, out double efficiency)
                    )
            {

            }
            else
            {
                double totalAhl = (powerRating * dailyDuty * weeklyDailyCycle) / (voltageSystemNominal * 7 * efficiency);
                ahl = ahl + totalAhl;
                currentAhl = totalAhl;

            }
            AHL = Convert.ToString(Math.Round(currentAhl, 2));
        }

        public bool checkAhlInput()
        {

            if (
                    !double.TryParse(PowerRating, out double powerRating) ||
                    !double.TryParse(DailyDuty, out double dailyDuty) ||
                    !double.TryParse(WeeklyDailyCycle, out double weeklyDailyCycle) ||
                    !double.TryParse(VoltageSystemNominal, out double voltageSystemNominal) ||
                    !double.TryParse(Efficiency, out double efficiency)
                    )
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool checkAhcInput()
        {

            if (
                ahl == 0 ||
                    !double.TryParse(WireEfficiency, out double powerRating) ||
                    !double.TryParse(BatteryEfficiency, out double dailyDuty) ||
                    !double.TryParse(PeakSunHours, out double weeklyDailyCycle)
                    )
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool checkDeratedDesignInput()
        {

            if (
                designCurrent == 0 ||
                    !double.TryParse(ModuleRate, out double moduleRate) ||
                    !double.TryParse(ManufactureRatedOutput, out double manufactureRatedOutput)

                    )
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool checkSeriesModuleInput()
        {

            if (
                    !double.TryParse(ModuleNominalVoltage, out double moduleNominalVoltage) ||
                    !double.TryParse(NominalSystemVoltage, out double nominalSystemVoltage)

                    )
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public bool checkCorrectedBatteryInput()
        {

            if (
                ahc == 0 ||
                    !double.TryParse(StorageDays, out double storageDays) ||
                    !double.TryParse(TempFactor, out double tempFactor) ||
                    !double.TryParse(MaxDepthDischarge, out double maxDepthDischarge)

                    )
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public bool checkBatteryRatingInput()
        {

            if (
                correctedBattery == 0 ||
                    !double.TryParse(BatteryRating, out double batteryRating)

                    )
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public bool checkBatteryNominalVoltageInput()
        {

            if (
                !double.TryParse(NominalSystemVoltage, out double nominalSystemVoltage) ||
                    !double.TryParse(BatteryNominalVoltage, out double batteryNominalVoltage)

                    )
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool checkModuleShortCircuitInput()
        {

            if (
                modulesInParallel == 0 ||
                    !double.TryParse(ModuleShortCircuitCurrent, out double moduleShortCircuitCurrent)

                    )
            {
                return false;
            }
            else
            {
                return true;
            }

        }

    }
}
