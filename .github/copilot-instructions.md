# GitHub Copilot Instructions for RimWorld Mod Project: Transport Downed Pawns (Continued)

## Mod Overview and Purpose

### Mod Name
**Transport Downed Pawns (Continued)**

### Description
The "Transport Downed Pawns (Continued)" mod, originally created by CornyTrace and updated by Targhetti, is designed to enhance the experience of managing colonists and prisoners in RimWorld. This mod allows unconscious or otherwise incapacitated members to be transported using a transport pod, improving logistics and emergency responses within the game. The mod has been updated to be compatible with versions 1.0 through 1.5. 

### Purpose
The main purpose of this mod is to provide players with a more streamlined and efficient way to handle incapacitated colonists during critical moments, such as attacks or emergencies requiring relocation.

## Key Features and Systems

- **Transport Capabilities**: Adds the ability for players to place incapacitated colonists and prisoners into transport pods manually.
- **Compatibility**: Updated for RimWorld versions 1.0 to 1.5. Note that the mod retains the name of the original version with slight naming distinctions (spaces included).
- **Maintenance**: Although testing is limited to non-DLC features, the mod provides robust functionality for the core game.
- **Error Handling**: Users are encouraged to utilize the Log Uploader for error reporting and to use the Discord channel for more nuanced support.

## Coding Patterns and Conventions

- **C# Files Setup**: The project contains two primary C# files focusing on transport functionality and main execution logic:
  - `Dialog_LoadTransporters_AddPawnsToTransferables.cs`: Includes a `Prefix` member for adding pawns to transfer lists.
  - `Main.cs`: Serves as the mod’s primary entry point.
- **Naming Conventions**: Types and members are named using PascalCase to conform to C# standards.
- **File Organization**: C# and XML files are kept separate, with clear naming to indicate their roles within the mod.

## XML Integration

- **About.xml**: Integrates the mod with RimWorld’s core systems and specifies dependencies. Ensure that the necessary Harmony dependencies are listed accurately.
- **Dependencies**: The mod relies on Harmony (brrainz.harmony) for patch management and code injection.

## Harmony Patching

- **Harmony Use Case**: This mod applies Harmony patches to modify the default behavior of RimWorld, specifically enabling transport for incapacitated pawns.
- **Prefix Patch**: The `Dialog_LoadTransporters_AddPawnsToTransferables.cs` file implements a prefix to alter transport loading behaviors.
- **Safe Patching**: Ensure all patches are safe by checking for conflicts with other mods and maintaining compatibility across updates.

## Suggestions for Copilot

1. **Code Completion and Testing**: Use Copilot to suggest additional methods to streamline pawn transport logic or test edge cases not yet covered.
2. **Error Handling**: Leverage Copilot to enhance error detection mechanisms, such as exception handling or logging details.
3. **Performance Optimization**: Consult Copilot for optimization hints, particularly in managing large lists of pawns during high-stress game scenarios.
4. **New Feature Proposals**: Request Copilot to brainstorm potential new features or improvements that could augment the transport experience, such as automated transport routines or broader compatibility features.
5. **Documentation Assistance**: Utilize Copilot for the generation of inline comments and documentation to maintain code readability and ease of future modifications.

Please ensure that these guidelines are followed to maintain consistency, compatibility, and functionality throughout the mod's updates and usage within the community. For further support and community engagement, don't hesitate to utilize dedicated RimWorld modding forums and Discord channels.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

