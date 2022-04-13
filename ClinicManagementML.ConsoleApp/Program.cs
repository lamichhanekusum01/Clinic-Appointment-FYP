// This file was auto-generated by ML.NET Model Builder. 

using System;
using ClinicManagementML.Model;

namespace ClinicManagementML.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                Itching = 1,
                Skin_rash = 1,
                Nodal_skin_eruptions = 1F,
                Dischromic__patches = 1F,
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Prognosis with predicted Prognosis from sample data...\n\n");
            Console.WriteLine($"Itching: {sampleData.Itching}");
            Console.WriteLine($"Skin_rash: {sampleData.Skin_rash}");
            Console.WriteLine($"Nodal_skin_eruptions: {sampleData.Nodal_skin_eruptions}");
            Console.WriteLine($"Continuous_sneezing: {sampleData.Continuous_sneezing}");
            Console.WriteLine($"Shivering: {sampleData.Shivering}");
            Console.WriteLine($"Chills: {sampleData.Chills}");
            Console.WriteLine($"Joint_pain: {sampleData.Joint_pain}");
            Console.WriteLine($"Stomach_pain: {sampleData.Stomach_pain}");
            Console.WriteLine($"Acidity: {sampleData.Acidity}");
            Console.WriteLine($"Ulcers_on_tongue: {sampleData.Ulcers_on_tongue}");
            Console.WriteLine($"Muscle_wasting: {sampleData.Muscle_wasting}");
            Console.WriteLine($"Vomiting: {sampleData.Vomiting}");
            Console.WriteLine($"Burning_micturition: {sampleData.Burning_micturition}");
            Console.WriteLine($"Spotting__urination: {sampleData.Spotting__urination}");
            Console.WriteLine($"Fatigue: {sampleData.Fatigue}");
            Console.WriteLine($"Weight_gain: {sampleData.Weight_gain}");
            Console.WriteLine($"Anxiety: {sampleData.Anxiety}");
            Console.WriteLine($"Cold_hands_and_feets: {sampleData.Cold_hands_and_feets}");
            Console.WriteLine($"Mood_swings: {sampleData.Mood_swings}");
            Console.WriteLine($"Weight_loss: {sampleData.Weight_loss}");
            Console.WriteLine($"Restlessness: {sampleData.Restlessness}");
            Console.WriteLine($"Lethargy: {sampleData.Lethargy}");
            Console.WriteLine($"Patches_in_throat: {sampleData.Patches_in_throat}");
            Console.WriteLine($"Irregular_sugar_level: {sampleData.Irregular_sugar_level}");
            Console.WriteLine($"Cough: {sampleData.Cough}");
            Console.WriteLine($"High_fever: {sampleData.High_fever}");
            Console.WriteLine($"Sunken_eyes: {sampleData.Sunken_eyes}");
            Console.WriteLine($"Breathlessness: {sampleData.Breathlessness}");
            Console.WriteLine($"Sweating: {sampleData.Sweating}");
            Console.WriteLine($"Dehydration: {sampleData.Dehydration}");
            Console.WriteLine($"Indigestion: {sampleData.Indigestion}");
            Console.WriteLine($"Headache: {sampleData.Headache}");
            Console.WriteLine($"Yellowish_skin: {sampleData.Yellowish_skin}");
            Console.WriteLine($"Dark_urine: {sampleData.Dark_urine}");
            Console.WriteLine($"Nausea: {sampleData.Nausea}");
            Console.WriteLine($"Loss_of_appetite: {sampleData.Loss_of_appetite}");
            Console.WriteLine($"Pain_behind_the_eyes: {sampleData.Pain_behind_the_eyes}");
            Console.WriteLine($"Back_pain: {sampleData.Back_pain}");
            Console.WriteLine($"Constipation: {sampleData.Constipation}");
            Console.WriteLine($"Abdominal_pain: {sampleData.Abdominal_pain}");
            Console.WriteLine($"Diarrhoea: {sampleData.Diarrhoea}");
            Console.WriteLine($"Mild_fever: {sampleData.Mild_fever}");
            Console.WriteLine($"Yellow_urine: {sampleData.Yellow_urine}");
            Console.WriteLine($"Yellowing_of_eyes: {sampleData.Yellowing_of_eyes}");
            Console.WriteLine($"Acute_liver_failure: {sampleData.Acute_liver_failure}");
            Console.WriteLine($"Fluid_overload: {sampleData.Fluid_overload}");
            Console.WriteLine($"Swelling_of_stomach: {sampleData.Swelling_of_stomach}");
            Console.WriteLine($"Swelled_lymph_nodes: {sampleData.Swelled_lymph_nodes}");
            Console.WriteLine($"Malaise: {sampleData.Malaise}");
            Console.WriteLine($"Blurred_and_distorted_vision: {sampleData.Blurred_and_distorted_vision}");
            Console.WriteLine($"Phlegm: {sampleData.Phlegm}");
            Console.WriteLine($"Throat_irritation: {sampleData.Throat_irritation}");
            Console.WriteLine($"Redness_of_eyes: {sampleData.Redness_of_eyes}");
            Console.WriteLine($"Sinus_pressure: {sampleData.Sinus_pressure}");
            Console.WriteLine($"Runny_nose: {sampleData.Runny_nose}");
            Console.WriteLine($"Congestion: {sampleData.Congestion}");
            Console.WriteLine($"Chest_pain: {sampleData.Chest_pain}");
            Console.WriteLine($"Weakness_in_limbs: {sampleData.Weakness_in_limbs}");
            Console.WriteLine($"Fast_heart_rate: {sampleData.Fast_heart_rate}");
            Console.WriteLine($"Pain_during_bowel_movements: {sampleData.Pain_during_bowel_movements}");
            Console.WriteLine($"Pain_in_anal_region: {sampleData.Pain_in_anal_region}");
            Console.WriteLine($"Bloody_stool: {sampleData.Bloody_stool}");
            Console.WriteLine($"Irritation_in_anus: {sampleData.Irritation_in_anus}");
            Console.WriteLine($"Neck_pain: {sampleData.Neck_pain}");
            Console.WriteLine($"Dizziness: {sampleData.Dizziness}");
            Console.WriteLine($"Cramps: {sampleData.Cramps}");
            Console.WriteLine($"Bruising: {sampleData.Bruising}");
            Console.WriteLine($"Obesity: {sampleData.Obesity}");
            Console.WriteLine($"Swollen_legs: {sampleData.Swollen_legs}");
            Console.WriteLine($"Swollen_blood_vessels: {sampleData.Swollen_blood_vessels}");
            Console.WriteLine($"Puffy_face_and_eyes: {sampleData.Puffy_face_and_eyes}");
            Console.WriteLine($"Enlarged_thyroid: {sampleData.Enlarged_thyroid}");
            Console.WriteLine($"Brittle_nails: {sampleData.Brittle_nails}");
            Console.WriteLine($"Swollen_extremeties: {sampleData.Swollen_extremeties}");
            Console.WriteLine($"Excessive_hunger: {sampleData.Excessive_hunger}");
            Console.WriteLine($"Extra_marital_contacts: {sampleData.Extra_marital_contacts}");
            Console.WriteLine($"Drying_and_tingling_lips: {sampleData.Drying_and_tingling_lips}");
            Console.WriteLine($"Slurred_speech: {sampleData.Slurred_speech}");
            Console.WriteLine($"Knee_pain: {sampleData.Knee_pain}");
            Console.WriteLine($"Hip_joint_pain: {sampleData.Hip_joint_pain}");
            Console.WriteLine($"Muscle_weakness: {sampleData.Muscle_weakness}");
            Console.WriteLine($"Stiff_neck: {sampleData.Stiff_neck}");
            Console.WriteLine($"Swelling_joints: {sampleData.Swelling_joints}");
            Console.WriteLine($"Movement_stiffness: {sampleData.Movement_stiffness}");
            Console.WriteLine($"Spinning_movements: {sampleData.Spinning_movements}");
            Console.WriteLine($"Loss_of_balance: {sampleData.Loss_of_balance}");
            Console.WriteLine($"Unsteadiness: {sampleData.Unsteadiness}");
            Console.WriteLine($"Weakness_of_one_body_side: {sampleData.Weakness_of_one_body_side}");
            Console.WriteLine($"Loss_of_smell: {sampleData.Loss_of_smell}");
            Console.WriteLine($"Bladder_discomfort: {sampleData.Bladder_discomfort}");
            Console.WriteLine($"Foul_smell_of_urine: {sampleData.Foul_smell_of_urine}");
            Console.WriteLine($"Continuous_feel_of_urine: {sampleData.Continuous_feel_of_urine}");
            Console.WriteLine($"Passage_of_gases: {sampleData.Passage_of_gases}");
            Console.WriteLine($"Internal_itching: {sampleData.Internal_itching}");
            Console.WriteLine($"Toxic_look__typhos_: {sampleData.Toxic_look__typhos_}");
            Console.WriteLine($"Depression: {sampleData.Depression}");
            Console.WriteLine($"Irritability: {sampleData.Irritability}");
            Console.WriteLine($"Muscle_pain: {sampleData.Muscle_pain}");
            Console.WriteLine($"Altered_sensorium: {sampleData.Altered_sensorium}");
            Console.WriteLine($"Red_spots_over_body: {sampleData.Red_spots_over_body}");
            Console.WriteLine($"Belly_pain: {sampleData.Belly_pain}");
            Console.WriteLine($"Abnormal_menstruation: {sampleData.Abnormal_menstruation}");
            Console.WriteLine($"Dischromic__patches: {sampleData.Dischromic__patches}");
            Console.WriteLine($"Watering_from_eyes: {sampleData.Watering_from_eyes}");
            Console.WriteLine($"Increased_appetite: {sampleData.Increased_appetite}");
            Console.WriteLine($"Polyuria: {sampleData.Polyuria}");
            Console.WriteLine($"Family_history: {sampleData.Family_history}");
            Console.WriteLine($"Mucoid_sputum: {sampleData.Mucoid_sputum}");
            Console.WriteLine($"Rusty_sputum: {sampleData.Rusty_sputum}");
            Console.WriteLine($"Lack_of_concentration: {sampleData.Lack_of_concentration}");
            Console.WriteLine($"Visual_disturbances: {sampleData.Visual_disturbances}");
            Console.WriteLine($"Receiving_blood_transfusion: {sampleData.Receiving_blood_transfusion}");
            Console.WriteLine($"Receiving_unsterile_injections: {sampleData.Receiving_unsterile_injections}");
            Console.WriteLine($"Coma: {sampleData.Coma}");
            Console.WriteLine($"Stomach_bleeding: {sampleData.Stomach_bleeding}");
            Console.WriteLine($"Distention_of_abdomen: {sampleData.Distention_of_abdomen}");
            Console.WriteLine($"History_of_alcohol_consumption: {sampleData.History_of_alcohol_consumption}");
            Console.WriteLine($"Fluid_overload_00: {sampleData.Fluid_overload_00}");
            Console.WriteLine($"Blood_in_sputum: {sampleData.Blood_in_sputum}");
            Console.WriteLine($"Prominent_veins_on_calf: {sampleData.Prominent_veins_on_calf}");
            Console.WriteLine($"Palpitations: {sampleData.Palpitations}");
            Console.WriteLine($"Painful_walking: {sampleData.Painful_walking}");
            Console.WriteLine($"Pus_filled_pimples: {sampleData.Pus_filled_pimples}");
            Console.WriteLine($"Blackheads: {sampleData.Blackheads}");
            Console.WriteLine($"Scurring: {sampleData.Scurring}");
            Console.WriteLine($"Skin_peeling: {sampleData.Skin_peeling}");
            Console.WriteLine($"Silver_like_dusting: {sampleData.Silver_like_dusting}");
            Console.WriteLine($"Small_dents_in_nails: {sampleData.Small_dents_in_nails}");
            Console.WriteLine($"Inflammatory_nails: {sampleData.Inflammatory_nails}");
            Console.WriteLine($"Blister: {sampleData.Blister}");
            Console.WriteLine($"Red_sore_around_nose: {sampleData.Red_sore_around_nose}");
            Console.WriteLine($"Yellow_crust_ooze: {sampleData.Yellow_crust_ooze}");
            Console.WriteLine($"Col133: {sampleData.Col133}");
            Console.WriteLine($"\n\nPredicted Prognosis value {predictionResult.Prediction} \nPredicted Prognosis scores: [{String.Join(",", predictionResult.Score)}]\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
