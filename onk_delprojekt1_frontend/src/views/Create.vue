<template>
    <v-container>
        <v-row class="text-center">
                <div style="width: 30%; margin: 1.66%">
                    <h3 class="headline">Create HaandVaerker</h3>
                    <form>

                        <v-text-field v-model="Surname" label="Surname">
                        </v-text-field>

                        <v-text-field v-model="Field" label="Field of Work">
                        </v-text-field>

                        <v-text-field v-model="firstName" label="First name">
                        </v-text-field>
                        <v-btn class="mr-4" @click="formSubmit()">submit</v-btn>
                    </form>
                </div>
                <div style="width: 30%; margin: 1.66%">
                    <h3 class="headline">Create Vaerkstoejskasse</h3>
                    <v-form
                        ref="form"
                        v-model="valid"
                        lazy-validation>

                        <v-select
                        v-model="VTKAnskaffet"
                        :items="items"
                        label="VTKAnskaffet"
                        ></v-select>

                        <v-text-field v-model="VTKFabrikat" label="VTKFabrikat">
                        </v-text-field>

                        <v-text-field v-model="VTKEjesAf" label="VTKEjesAf">
                        </v-text-field>

                        <v-text-field v-model="VTKModel " label="VTKModel ">
                        </v-text-field>

                        <v-text-field v-model="VTKSerienummer " label="VTKSerienummer ">
                        </v-text-field>

                        <v-text-field v-model="VTKFarve" label="VTKFarve">
                        </v-text-field>

                        <v-text-field v-model="VTKSerienummer " label="VTKSerienummer ">
                        </v-text-field>

                        <v-text-field v-model="VTKSerienummer" label="VTKSerienummer ">
                        </v-text-field>
                    <v-btn class="mr-4" @click="submit">submit</v-btn>
                    </v-form>
                </div>
                <div style="width: 30%; margin: 1.66%">
                    <h3 class="headline">Create Vaerktoej</h3>
                    <v-form
                        ref="form"
                        v-model="valid"
                        lazy-validation>

                        <v-select
                        v-model="VTKAnskaffet"
                        :items="items"
                        label="VTKAnskaffet"
                        ></v-select>

                        <v-text-field v-model="VTFabrikat" label="VTFabrikat">
                        </v-text-field>

                        <v-text-field v-model="VTModel" label="VTModel">
                        </v-text-field>

                        <v-text-field v-model="VTSerienr" label="VTSerienr">
                        </v-text-field>

                        <v-text-field v-model="VTType" label="VTType">
                        </v-text-field>

                        <v-text-field v-model="LiggerIvtk" label="LiggerIvtk">
                        </v-text-field>
                    <v-btn class="mr-4" @click="submit">submit</v-btn>
                    </v-form>
                </div>
        </v-row>
    </v-container>
</template>

<script>


export default {
    
    




    data() {
        return {
            Surname: '',
            Field: '',
            firstName: ''
        }
    },
    methods: {
            formSubmit() {
                
                let currentObj = this;
                this.axios.post('https://localhost:44339/api/Haandvaerkers', {
                    HVAnsaettelsedato: new Date(),
                    HVEfternavn: this.Surname,
                    HVFagomraade: this.Field,
                    HVFornavn: this.firstName
                })
                .then(function (response) {
                    currentObj.output = response.data;
                })
                .catch(function (error) {
                    currentObj.output = error;
                });
            }
        }
}
</script>