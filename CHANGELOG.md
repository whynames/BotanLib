## [1.0.2](https://github.com/whynames/BotanLib/compare/v1.0.1...v1.0.2) (2023-11-25)


### Bug Fixes

* 155 ([f116aba](https://github.com/whynames/BotanLib/commit/f116aba570f6e0c8bff3311f875db5c18fdffa66))
* 444 ([7260b50](https://github.com/whynames/BotanLib/commit/7260b508e7ea385a8ba2789660acb175c48ae207))
* aaaaa ([31c6dcf](https://github.com/whynames/BotanLib/commit/31c6dcfa213c2bbba5f432acc17af07647748e8f))
* aaaaa ([aae7b35](https://github.com/whynames/BotanLib/commit/aae7b35644681c7862d1baa05e57dccb129a0528))
* again ([56aa97b](https://github.com/whynames/BotanLib/commit/56aa97b26a8dc087c78c5fac8d693da454d7a451))
* againagain ([7569fd8](https://github.com/whynames/BotanLib/commit/7569fd80a0f661296e4990b3820dab3e4d6cad5e))
* againagian ([9c21da1](https://github.com/whynames/BotanLib/commit/9c21da1d28d4ed392424be15856a7562f9baf3a6))
* aggg ([1302ec1](https://github.com/whynames/BotanLib/commit/1302ec13adc2f6418252167285eb4175d6c9e5c7))
* asffads ([ddc8cad](https://github.com/whynames/BotanLib/commit/ddc8cad5a3971309d1346c400f12efc5270856fe))
* hope ([8226b5f](https://github.com/whynames/BotanLib/commit/8226b5fa3b0fc5b7833542d791d4a5e970873ee6))
* new ([4477249](https://github.com/whynames/BotanLib/commit/44772493fd9d7b6a9bc6f6d7f12961683962c928))
* new ([52046aa](https://github.com/whynames/BotanLib/commit/52046aa5aee010f11201c0d129f250c20fd3a758))
* new ReadMe ([56d16c0](https://github.com/whynames/BotanLib/commit/56d16c0f5194f0dffed09f36c5cd18e538951b5d))
* s ([1845edf](https://github.com/whynames/BotanLib/commit/1845edfc09e376500279c91a2895b1a1b1da704d))
* sa ([38067b7](https://github.com/whynames/BotanLib/commit/38067b76654e9bfe0025c436962318f4111b760f))
* sad ([7c771fb](https://github.com/whynames/BotanLib/commit/7c771fbb235ac24c5c75b767b61a4f691c7c855b))
* sasd ([6a8799c](https://github.com/whynames/BotanLib/commit/6a8799c2293c82010e1697e76dd59a741902fe6b))
* sassa ([2d0c672](https://github.com/whynames/BotanLib/commit/2d0c6720fe8ef3bef33a3180d410b41b8f3b3dbc))
* sfasfs ([c7c0d25](https://github.com/whynames/BotanLib/commit/c7c0d254d55581c8963c10052bedf5205797d327))
* sx ([2a21358](https://github.com/whynames/BotanLib/commit/2a213589121c040ab432079360baeb630c1ae5e9))
* tessssttt ([b7dbae4](https://github.com/whynames/BotanLib/commit/b7dbae4f3ebb5d7acbdc0b14358a180d97d2eda4))
* tessst ([847eb18](https://github.com/whynames/BotanLib/commit/847eb186462e7b9bd9f4f32b0af8462736893dff))
* tesstt ([518a349](https://github.com/whynames/BotanLib/commit/518a3491e980432f2a96dc379d73b76eb725fc91))
* testAgain ([66b48ca](https://github.com/whynames/BotanLib/commit/66b48ca5fbb1c268875f08a2686864dc7ab74e36))
* testttt ([20dd857](https://github.com/whynames/BotanLib/commit/20dd8576059e2e88bda357b795e52f1184483c58))

# Change Log:

## 1.4.4

- Enhancement: Updating `package.json` version number to `1.0.0-pre.1`, per latest Unity standard.
- Enhancement: Updating documentation to the latest folder structure and content specs, such as linking to the `Samples~` section in the Unity's documentation instead of saying, "as of this writing, there is no official documentation" (when there obviously is, now.)
- Bug Fix: forgot to ignore `Documentation~/index.md`.

## 1.4.3

- Enhancement: restructuring the documentation so that the [`README.md`](/README.md) at the root of the project becomes the homepage of the DocFX-generated documentation.  The old `index.md` has now been added to `Documentation~/manual` folder, as the first page describing the content of this package.  This should make updating documentation easier for future projects, as only the `README.md` file needs to be updated to change the homepage.
- Enhancement: extending license year to 2022

## 1.4.2

- Enhancement: adding conditionals to [`.github/workflows/documentation.yml`](/.github/workflows/documentation.yml) and [`.github/workflows/mirror.yml`](/.github/workflows/mirror.yml) to prevent the jobs from running on other repos copying this template automatically.  Added comments, and updated documentation indicating these conditional's purpose, and how to remove them.

## 1.4.1

- Enhancement: changing the mirror action to [this one](https://github.com/marketplace/actions/mirroring-repository).

## 1.4.0

- Feature: added Github Action to mirror the repository to [`Bitbucket`](https://bitbucket.org/OmiyaGames/template-unity-package) automatically.  This new file is available here: [`.github/workflows/mirror.yml`](/.github/workflows/mirror.yml).
- Enhancement: updated [Customize Package manual](https://omiyagames.github.io/template-unity-package/manual/customizePackage.html) talking about what files from `.github` can be deleted or edited.

## 1.3.1

- Typo: Fixed the documentation build status badge in [`README.md`](/README.md).

## 1.3.0

- Feature: added Github Action to auto-generate documentation in the [`Documentation~`](/Documentation~) folder using [DocFX for Unity](https://github.com/NormandErwan/DocFxForUnity) project as reference.
- Feature: adding Github feature, sponsorship!  The `FUNDING.yml` file in `.github` folder adds a sponsorship button on Github with a link to [Ko-Fi](https://ko-fi.com/omiyagames).
- Enhancement: Updated [`README.md`](/README.md) to link to the newly-generated documentation, and provide better installation instructions.

## 1.2.2

- Enhancement: making the platform [`OmiyaGames.Template.Editor.asmdef`](/Editor/OmiyaGames.Template.Editor.asmdef) and [`OmiyaGames.Template.Editor.Tests.asmdef`](/Tests/Editor/OmiyaGames.Template.Editor.Tests.asmdef) supports to only the editor.

## 1.2.1

- Rename: `EditorExampleTest.cs` to [`TestEditorExample.cs`](/Tests/Editor/TestEditorExample.cs). Updated class name along with it.
- Rename: `RuntimeExampleTest.cs` to [`TestRuntimeExample.cs`](/Tests/Editor/TestRuntimeExample.cs). Updated class name along with it.
- Typo: Removed `[CustomEditor(typeof(RuntimeExample))]` attribute from [`EditorExampleTest.cs`](/Tests/Editor/TestEditorExample.cs). It serves no purpose.
- Typo: Removed `[CustomEditor(typeof(RuntimeExample))]` attribute from [`EditorExampleTest.cs`](/Tests/Editor/TestEditorExample.cs). It serves no purpose.

## 1.2.0

- Feature: Updated the [`Tests`](/Tests) assembly definition files and example scripts with proper configuration for editing/creating new unit test scripts. Also updated [`package.json`](/package.json) with NUnit as a required dependency.
- Enhancement: Added significantly more information in [`README.md`](/README.md) so other people can use a more fleshed-out markdown format to start their documentation.
- Enhancement: Changing [`package.json`](/package.json) into a type -> Tool, and added one more keyword.
- Enhancement: Noting [`THIRD PARTY NOTICES.md`](/THIRD%20PARTY%20NOTICES.md) is just an example, and this project doesn't actually use any 3rd party tools yet (besides unit testing, but I think that's already implied).

## 1.1.0

- Feature: adding a [`Documentation~/Doxyfile`](/Documentation~/Doxyfile) to make generating [Doxygen](http://doxygen.nl/) files a little easier.

## 1.0.2

- Typo: renaming `Documentation~/index.md` to [`Documentation~/Template.md`](/Documentation~/Template.md) to match Unity recommendation.

## 1.0.1

- Bug fix: [`Editor/EditorExample.cs`](/Editor/EditorExample.cs) now compiles properly.
- Typo: updated namespace in [`Tests/Editor/EditorExampleTest.cs`](/Tests/Editor/EditorExampleTest.cs) to inlucde `Test`.
- Typo: changing the [`THIRD PARTY NOTICES.md`](/THIRD%20PARTY%20NOTICES.md) Credits section to use a list, so each field is in its own line.

## 1.0.0

- Initial release:
    - Confirmed the template project works by battle-testing it to [Omiya Games - Common](https://github.com/OmiyaGames/omiya-games-common) package.
- Updated every text to be more generic.
