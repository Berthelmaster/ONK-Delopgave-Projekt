<template>
    <v-container>
        <v-row class="text-center">
                <div style="width: 30%; margin: 1.66%">
                    <h3 class="headline">Create HaandVaerker</h3>
                    <v-form
                        ref="form"
                        v-model="valid"
                        lazy-validation>

                        <v-select
                        v-model="select"
                        :items="items"
                        label="Start Date"
                        ></v-select>

                        <v-text-field v-model="Surname" label="Surname">
                        </v-text-field>

                        <v-text-field v-model="Field" label="Field of Work">
                        </v-text-field>

                        <v-text-field v-model="firstName" label="First name">
                        </v-text-field>
                    </v-form>
                </div>
                <div style="width: 30%; margin: 1.66%">
                    <h3 class="headline">Create Vaerkstoejskasse</h3>
                </div>
                <div style="width: 30%; margin: 1.66%">
                    <h3 class="headline">Create HaandVaerker</h3>
                </div>
        </v-row>
    </v-container>
</template>

<script>

export default {
    
    data: () => ({
        items: [
            new Date(),
            new Date(),
            new Date()
        ]
    })
}
</script>