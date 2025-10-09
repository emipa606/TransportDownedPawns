# Copilot Instructions for Transport Downed Pawns (Continued) Mod

## Mod Overview and Purpose

The **Transport Downed Pawns (Continued)** mod is an update to the originally created mod by CornyTraces, revitalized to be compatible with RimWorld versions 1.0 to 1.5. The main objective of this mod is to enhance gameplay by enabling players to transport unconscious or otherwise incapacitated colonists and prisoners using transport pods. This capability adds a strategic layer for managing emergency situations and expanding colonist rescue operations within the game.

## Key Features and Systems

- **Transport of Downed Pawns**: Allows players to load immobile pawns into transport pods, facilitating easier relocation or rescue across the map.
- **Compatibility with Multiple Versions**: Updated to function seamlessly with RimWorld versions 1.0 through 1.5.
- **User Experience**: Maintains familiar functionality from the original mod, ensuring users have a consistent experience.

## Coding Patterns and Conventions

### General Conventions

- **Consistent Naming**: Use PascalCase for class names and methods, following C# conventions for readability.
- **Single Responsibility Principle**: Structure classes and methods so that they handle a single responsibility or functionality, promoting modular and maintainable code.

### Specific Files

- **Main.cs**:
  - Ensure the main control flow of the mod is organized within the `Main` class.
  - Encapsulate initialization logic and general management of mod settings.

- **TransportPrisonersPatch.cs**:
  - Implement static methods for patching transport functionality.
  - Focus on the conditional logic for checking if a pawn can be included in a transport pod.

## XML Integration

- Utilize RimWorld's XML Defs to extend and modify game behaviors in tandem with C# logic.
- Ensure Defs for transport pods are updated to include downed pawns as valid cargo.
- XML changes should be documented inline where appropriate, explaining the purpose of modifications for future updates.

## Harmony Patching

- **Harmony Library**: Use the Harmony library to apply runtime patches to the game, allowing modifications without altering the original source code.
- **Patch Structure**: 
  - Identify and target the RimWorld methods related to transport pod functionality.
  - Implement prefix or postfix methods to adjust transport logic.
- **Logging and Debugging**: Implement logging statements to help trace execution flow during patching. This assists in troubleshooting and ensures the mod operates as expected.

## Suggestions for Copilot

- **Implement Auto-Completion**: Leverage Copilot's capabilities for method auto-completion and suggestions while writing patch logic.
- **Refactor Assistance**: Use Copilot to suggest refactoring opportunities for cleaner, more efficient code, especially in areas like patch application logic.
- **XML and Class Integration**: Utilize Copilot to bridge C# logic with XML changes effectively, ensuring seamless integration.
- **Documentation Help**: Encourage Copilot to assist in generating user and developer documentation inline with code updates.

By following this structured guide, contributors can efficiently update and maintain the Transport Downed Pawns (Continued) mod, ensuring compatibility and functionality with the latest versions of RimWorld.
