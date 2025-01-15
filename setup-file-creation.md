# Setup File Creation for StockManagement Project

## 1. Create a New Project
- Open **Visual Studio**.
- Select **C# Windows Forms App**.
- Name your project **StockManagement**.

## 2. Design Your Project
- Design the layout and user interface of your **StockManagement** application.

## 3. Install Extension
- Go to **Extensions > Manage Extensions**.
- Search for and install the **Installer Extension**.

## 4. Close Visual Studio
- Once the extension is installed, **close** Visual Studio.

## 5. Modify Installation
- After closing, **click on Modify** to update Visual Studio.

## 6. Open Visual Studio and Add a New Project
- Open Visual Studio again.
- **Open the previous project** (StockManagement).
- Click on **Solution** > **Add New Project**.
- Search for and select **Setup Project** and create a new project inside the existing solution.

## 7. Explorer View
- You will see two panes:
  - **Left Side**: Folders (Application Folder, User’s Desktop, User’s Program Menu).
  - **Right Side**: This will display options for each folder.

## 8. Add Shortcuts
- Add shortcuts to the following locations:
  - **User’s Desktop**.
  - **User’s Program Menu**.

## 9. Add Project Output
- In the **Application Folder** (left sidebar):
  - Click on an empty area in the **right side panel**.
  - Select **Add** > **Project Output** > **Publish Items**.
  - Set the **Config** to **Active**.

## 10. Add Icon to the Project
- The icon should have a `.ico` extension and be used to create shortcuts.
- You can get free icons from websites like **icon-icons.com**.
  - Choose an icon of size **256px**.
- Add the icon to the **Application Folder** by right-clicking and selecting **Add** > **File**.

## 11. Create Shortcuts
- After adding the icon:
  - Right-click on the **Publish Item** file.
  - Select **Create Shortcut** and rename the shortcut to your project name.
  - Assign the **icon** to the shortcut from the **Properties palette**.

## 12. Move the Shortcut
- **Cut** the shortcut (named after your project) from the **Application Folder**.
- **Paste** it into both **User’s Desktop** and **User’s Program Menu**.

## 13. Modify Setup Project Properties
- **Click on the Setup Project**.
  - Change the properties: **Author** and **Manufacturer**.
- **Right-click** on the Setup Project and click on **Build**.

## 14. Final Steps
- **Hurrah!** Your project is successfully created.
- Right-click on the **Setup Project** and select **Open in Explorer** to view the setup file.

---

### Congratulations! You have now successfully created and built the setup file for your **StockManagement** project.
