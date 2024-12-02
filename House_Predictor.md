# **Machine Learning Using ML.NET in Visual Studio 2022**

## **1. Create a Console Application**

### Step 1: Select Console App
Open Visual Studio 2022 and create a new Console Application.
![Step 1](https://github.com/user-attachments/assets/d41d8ab4-1e52-4df7-a45c-0ef91d2c7d5a)

### Step 2: Name the Project
Give your project a suitable name.
![Step 2](https://github.com/user-attachments/assets/f167ab0c-d371-446a-9ce9-b5e6f611029b)

### Step 3: Create the Project
Click "Create" to initialize the project.
![Step 3](https://github.com/user-attachments/assets/007f8851-5610-4823-b4d8-d6629972dbe3)

## **2. Setting Up the Default Code**

### Step 4: Default Program.cs Code
Visual Studio generates a default `Program.cs` file with basic code.
![Step 4](https://github.com/user-attachments/assets/17b4a217-b084-40ef-9c26-c6ecb779d658)

### Step 5: Refactor into a Class
Refactor the code into a class for better structure and organization.
![Step 5](https://github.com/user-attachments/assets/a4c85abe-06c8-4c27-b87d-6da84ac76276)

## **3. Importing and Using the Dataset**

### Step 6: Copy the Dataset
Copy your dataset (e.g., `housing.csv`) from the appropriate location.
![Step 6](https://github.com/user-attachments/assets/1c9c0f02-43cd-476a-ae39-132f26ac2038)

### Step 7: Paste Dataset in the Project (not solution)
Paste the dataset into the project folder (not the solution folder).
![Step 7](https://github.com/user-attachments/assets/952300e6-883e-4fff-8b67-e937aadaca0a)

### Step 8: Open the Dataset
Double-click the CSV file to view its data in Visual Studio.
![Step 8](https://github.com/user-attachments/assets/5a932708-23e5-46f3-835f-261e21954ce2)

## **4. Installing ML.NET**

### Step 9: Manage NuGet Packages
Right-click on "Dependencies" in Solution Explorer and click `Manage NuGet Packages`.
![Step 9](https://github.com/user-attachments/assets/433f5ce7-35e6-463f-94f4-39b10d92875a)

### Step 10: Search for Microsoft.ML
In the "Browse" tab, search for `microsoft.ml`.
![Step 10](https://github.com/user-attachments/assets/f86b3823-3fc0-414f-93f1-60ebd7218df7)

### Step 11: Download the Package
Click the download arrow to install the `Microsoft.ML` package.
![Step 11](https://github.com/user-attachments/assets/9f5ddfb1-200d-4f97-806b-98536c7f99e8)

### Step 12: Apply and Accept Changes
Click `Apply` and then `Accept` to confirm the installation of the package.
![Step 12](https://github.com/user-attachments/assets/2c63492f-fbc4-430d-ba25-11f2cef8f433)  
![Step 12](https://github.com/user-attachments/assets/cd74ce61-db25-4205-9d92-9a9c00120214)

## **5. ML.NET Setup and Model Creation**

### Initialize MLContext

#### Step 13: Import Microsoft.ML and Initialize Context
Add `using Microsoft.ML;` at the top and initialize `MLContext` for machine learning tasks.
![Step 13](https://github.com/user-attachments/assets/ca9c0a31-7be8-4153-a5ff-3f4f6061aa72)

### Load Data

#### Step 14: Load Data from CSV
Load data into a `HouseData` object using `LoadFromTextFile` method.
![Step 14](https://github.com/user-attachments/assets/0f4cec6c-1a10-4ccd-b021-40f201124d79)

#### Step 15: Define `HouseData` Class
Create an internal class `HouseData` to resolve type safety errors and define the data columns.

`HouseData.cs`

```csharp
using Microsoft.ML.Data;

namespace HousePredictor
{
    internal class HouseData
    {
        [LoadColumn(0)]
        public float Longitude { get; set; }

        [LoadColumn(1)]
        public float Latitude { get; set; }

        [LoadColumn(2)]
        public float HousingMedianAge { get; set; }

        [LoadColumn(3)]
        public float TotalRooms { get; set; }

        [LoadColumn(4)]
        public float TotalBedrooms { get; set; }

        [LoadColumn(5)]
        public float Population { get; set; }

        [LoadColumn(6)]
        public float Households { get; set; }

        [LoadColumn(7)]
        public float MedianIncome { get; set; }

        [LoadColumn(8), ColumnName("Label")]
        public float MedianHouseValue { get; set; }

        [LoadColumn(9)]
        public string OceanProximity { get; set; }
    }
}
```



## **6. Data Preparation and Model Training**

### Split Data and Feature Selection

#### Step 16: Split Data
Split data into training (80%) and testing (20%) sets.  
Exclude `Label` and `OceanProximity` columns when selecting features.  
![Step 16](https://github.com/user-attachments/assets/c99d989b-9902-49b9-9d1a-7a58888517b8)

### Create Pipeline and Transform Data

#### Step 17: Build the Pipeline
Apply transformations like text featurization, feature concatenation, and set up the regression trainer (`LbfgsPoissonRegression`).  
![Step 17](https://github.com/user-attachments/assets/d726cd1e-15ae-41af-9f18-6ab7d04ef8e3)



### Train the Model and Make Predictions

#### Step 18: Train the Model and Predict
Train the model using the training data and make predictions on the test data.
![Step 18](https://github.com/user-attachments/assets/8fd71562-37b2-4749-846b-57f94f0b29d6)



### Evaluate the Model

#### Step 19: Evaluate the Model Performance
Evaluate the model's performance using metrics such as R-squared.
![Step 19](https://github.com/user-attachments/assets/1fc9b875-adf2-4565-a820-25ad9335c7e1)


## **7. Full Program Code**
`Program.cs`

```csharp
using System;
using Microsoft.ML;

namespace House_Predictor
{
    class Program
    {
        static void Main(string[] args)
        {
                
            // 1. Initialize Context
            var context = new MLContext();

            // 2. Load Data
            var data = context.Data.LoadFromTextFile<HouseData>("./housing.csv",
                hasHeader: true, separatorChar: ',');

            // 3. Split Data
            var split = context.Data.TrainTestSplit(data, testFraction: 0.2);

            // 4. Feature Selection
            var features = split.TrainSet.Schema.
                Select(column => column.Name).
                Where(colname => colname != "Label" && colname != "OceanProximity").
                ToArray();

            // 5. Create Pipeline and Transform Data
            var pipleline = context.Transforms.Text.FeaturizeText("Text", "OceanProximity")
            .Append(context.Transforms.Concatenate("Features", features))
            .Append(context.Transforms.Concatenate("Feature", "Features", "Text"))
            .Append(context.Regression.Trainers.LbfgsPoissonRegression());

            // 6. Train the Model and Make predictions
            var model = pipleline.Fit(split.TrainSet);
            var predictions = model.Transform(split.TestSet);

            // 7. Evaluate the Model
            var metrics = context.Regression.Evaluate(predictions);
            Console.WriteLine($"R^2: {metrics.RSquared}");
            Console.WriteLine($"RMS error: {metrics.RootMeanSquaredError}");

        }
    }
}
```



The code above follows these steps:
1. Initializes `MLContext` for machine learning tasks.
2. Loads data from the CSV file into the `HouseData` class.
3. Splits the data into training and test sets (80/20 split).
4. Defines the features and prepares the data by transforming the text columns and concatenating the features.
5. Trains the model using `LbfgsPoissonRegression`.
6. Makes predictions using the trained model.
7. Evaluates the model's performance using regression metrics like R-squared.

