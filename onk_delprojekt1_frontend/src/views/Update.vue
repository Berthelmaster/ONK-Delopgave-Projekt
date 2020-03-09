<template>
    <v-container>
        <v-row class="text-center">
                <div style="width: 30%; margin: 1.66%">
                    <h3 class="headline">Update HaandVaerker</h3>
                    <form>
                        <v-text-field v-model="Id" label="Id"></v-text-field>
                        <v-text-field v-model="Firstname" label="First name"></v-text-field>
                        <v-btn class="mr-4" @click="submit">submit</v-btn>
                    </form>
                </div>
                <div style="width: 30%; margin: 1.66%">
                    <h3 class="headline">Update Vaerkstoejskasse</h3>
                </div>
                <div style="width: 30%; margin: 1.66%">
                    <h3 class="headline">Update HaandVaerker</h3>
                </div>
        </v-row>
    </v-container>
</template>

<script>

export default {
    
}
</script>